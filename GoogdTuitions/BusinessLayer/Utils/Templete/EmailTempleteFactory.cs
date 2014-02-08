using System;
using System.IO;
using System.Linq;
using DataAccessLayer.Email;
using DataAccessLayer.Response;

namespace BusinessLayer.Utils.Templete
{
    /// <summary>
    /// This class will return EmailTempleteFactory
    /// <Author>Muhammad Arslan</Author>
    /// <Dated>10-May-2013</Dated>
    /// </summary>
    public class EmailTempleteFactory
    {
        public static string GetEmailTemplate(EmailParams emailParams)
        {
            if (emailParams is SignupEmailParms)
                return GetSignupMailTemplate(emailParams);
            if (emailParams is SubscriptionParams)
                return GetSubscriptionTemplate(emailParams);
            if (emailParams is ForgotPasswordParams)
               return GetForgotPasswordTemplate(emailParams);
            return String.Empty;
        }
        private static String GetSignupMailTemplate(EmailParams emailParams)
        {
            return GetTemplate("/Template/SignupTemplate.htm",emailParams);
        }
        private static String GetSubscriptionTemplate(EmailParams emailParams)
        {
            return GetTemplate("/Template/SubscriptionTemplate.htm",emailParams);
        }
        private static string GetForgotPasswordTemplate(EmailParams emailParams)
        {
            return GetTemplate("/Template/ForgotPasswordTemplate.html", emailParams);
        }
        private static string GetTemplate(String templateFileName, EmailParams emailParams)
        {
            try
            {
                var filePath = System.Web.HttpContext.Current.Server.MapPath(templateFileName);
                var streamReader = File.OpenText(filePath);
                var contents = streamReader.ReadToEnd();
                contents = ReplaceParams(contents, emailParams);
                return contents;
            }
            catch (Exception)
            {
                return ResponseMessages.Error;
            }
        }

        private static string ReplaceParams(String emailTemplate, EmailParams emailParams)
        {
            var parameters = emailParams.GetEmailParameters();
            return parameters.Aggregate(emailTemplate, (current, entry) => current.Replace(entry.Key, entry.Value));
        }
    }
}
