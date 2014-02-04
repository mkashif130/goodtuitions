using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DataAccessLayer.Email;

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
            {
                return GetSignupMailTemplate(emailParams);
            }
            if (emailParams is SubscriptionParams)
            {
                return GetSubscriptionTemplate(emailParams);
            }
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

        private static string GetTemplate(String templateFileName, EmailParams emailParams)
        {
            try
            {
                String filePath = System.Web.HttpContext.Current.Server.MapPath(templateFileName);
                StreamReader streamReader = File.OpenText(filePath);
                String contents = streamReader.ReadToEnd();
                contents = ReplaceParams(contents, emailParams);
                return contents;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private static string ReplaceParams(String emailTemplate, EmailParams emailParams)
        {
            var parameters = emailParams.GetEmailParameters();
            return parameters.Aggregate(emailTemplate, (current, entry) => current.Replace(entry.Key, entry.Value));
        }
    }
}
