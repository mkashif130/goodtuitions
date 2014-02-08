using System;
using System.Net;
using System.Net.Http;
using BusinessLayer.DataLinkLayer;
using BusinessLayer.Repository.Email;
using BusinessLayer.Response;
using BusinessLayer.Utils.Email;
using BusinessLayer.Utils.Templete;
using DataAccessLayer.Email;
using DataAccessLayer.Response;
using DataAccessLayer.Login;

namespace BusinessLayer.Processors.Email
{
    public class VerificationTokenProcessor
    {
        public HttpResponseMessage Send(VerificationTokenEntity verificationToken)
        {
            var token = Guid.NewGuid().ToString();
            verificationToken.Token = token;
            verificationToken.TokenPurpose = TokenConstants.ForgotPassword;
            verificationToken.IsConsumed = false;
            verificationToken.ExpiryTime = TokenConstants.ExpiryTime;
            var response = Save(verificationToken);
            if (response.StatusCode == HttpStatusCode.Created)
            {
            var verifyLink = AppConfigProperty.GetStringProperty(AppConfigProperty.TuitionUiBaseUrl) + "WebPages/PasswordReset/Default.aspx?Token=" +
                                 token;
                verificationToken.Token = verifyLink;
                var forgotPasswordParams = new ForgotPasswordParams(verificationToken);
                var template = EmailTempleteFactory.GetEmailTemplate(forgotPasswordParams);
                if (template != ResponseMessages.Error)
                {
                    return SendEmail.Send(template, verificationToken.EmailAddress, TokenConstants.ForgotPassword) ? new HttpResponseMessage(HttpStatusCode.OK) : HttpExceptionResponse.EmailNotSent;   
                }
                return HttpExceptionResponse.TemplateNotFound;
            }
            return response;
        }
        private static HttpResponseMessage Save(VerificationTokenEntity verificationToken)
        {
            var verificationTokenRepository = new VerificationTokenRepository();
            var response= verificationTokenRepository.Save(verificationToken);
            if (response==ResponseMessages.Created)
            {
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            return response == ResponseMessages.NetworkError ? HttpExceptionResponse.NetworkError : HttpExceptionResponse.UnknownError;
        }
        public HttpResponseMessage Verify(PasswordResetEntity passwordReset)
        {
            var verificationTokenRepository = new VerificationTokenRepository();
            var verificationToken = verificationTokenRepository.GetSingle(passwordReset.Token);
            if (verificationToken!=null)
            {
                if (verificationToken.IsConsumed)
                {
                    return HttpExceptionResponse.TokenAlreadyUsed;
                }
                if (verificationToken.CreatedTimestamp.AddMinutes(verificationToken.ExpiryTime)>DateTime.Now)
                {
                    return HttpExceptionResponse.TokenExpired;
                }
                var response=ResetPassword(passwordReset.Password,verificationToken.EmailAddress);
                return response;
            }
            return HttpExceptionResponse.InvalidToken;
        }

        private static HttpResponseMessage ResetPassword(string password, string emailAddress)
        {
            var verificationTokenRepository = new VerificationTokenRepository();
            var response = verificationTokenRepository.ResetPassword(password, emailAddress);
            if (response == ResponseMessages.Updated)
            {
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            return response == ResponseMessages.NetworkError ? HttpExceptionResponse.NetworkError : HttpExceptionResponse.UnknownError;
        }
    }
}
