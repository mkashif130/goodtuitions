using BusinessLayer.DataLinkLayer;
using System;
using System.Net.Mail;

namespace BusinessLayer.Utils.Email
{
    /// <summary>
    /// This class will send email to the user
    /// <Author>Muhammad Arslan</Author>
    /// <Dated>26-Jan-2014</Dated>
    /// </summary>
    public class SendEmail
    {

        public static bool Send(String emailTemplate, String emailTo, String subject)
        {
            var from = AppConfigProperty.GetStringProperty(AppConfigProperty.TuitionMailFrom);
            var password = AppConfigProperty.GetStringProperty(AppConfigProperty.TuitionMailPassword);
            var host = AppConfigProperty.GetStringProperty(AppConfigProperty.TuitionMailHost);
            var name = AppConfigProperty.GetStringProperty(AppConfigProperty.TuitionMailName);
            var port = AppConfigProperty.GetStringProperty(AppConfigProperty.TuitionMailPort);
            try
            {
                var mail = new MailMessage {From = new MailAddress(@from, name)};

                // Set the to and from addresses.
                // The from address must be your GMail account
                mail.To.Add(new MailAddress(emailTo));

                // Define the message
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = emailTemplate;

                // Create a new Smpt Client using Google's servers
                var mailClient = new SmtpClient
                                     {
                                         Host = host,
                                         Port = int.Parse(port),
                                         EnableSsl = true,
                                         UseDefaultCredentials = true,
                                         Credentials = new System.Net.NetworkCredential(@from, password)
                                     };


                // This is the critical part, you must enable SSL
                //mailclient.EnableSsl = false;

                // Specify your authentication details
                mailClient.Send(mail);
                mailClient.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
