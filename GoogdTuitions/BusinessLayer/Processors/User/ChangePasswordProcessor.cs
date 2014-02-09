using System.Net;
using System.Net.Http;
using BusinessLayer.Repository;
using BusinessLayer.Repository.User;
using BusinessLayer.Response;
using BusinessLayer.Utils.Password;
using DataAccessLayer.User;
using DataAccessLayer.Response;
using BusinessLayer.Repository.Login;

namespace BusinessLayer.Processors.User
{
    public class ChangePasswordProcessor
    {
        public HttpResponseMessage Update(ChangePasswordEntity changePassword)
        {
            var repository = new ChangePasswordRepository();
            var verify = Verify(changePassword);
            if (verify)
            {
                var response = repository.UpdatePassword(changePassword.NewPassword,changePassword.EmailAdderss,Constants.Update);
                if (response == ResponseMessages.Updated)
                {
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                return response == ResponseMessages.NetworkError ? HttpExceptionResponse.NetworkError : HttpExceptionResponse.UnknownError;
            }
            return HttpExceptionResponse.AuthenticationFail;
        }

        private static bool Verify(ChangePasswordEntity changePassword)
        {
            var repository = new LoginRepository();
            var response = repository.GetSingle(changePassword.EmailAdderss);
            return response != null && response.PasswordHash == PasswordGenerator.EncryptPassword(changePassword.CurrentPassword, response.PasswordSalt);
        }
    }
}
