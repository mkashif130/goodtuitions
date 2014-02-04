using System;
using System.Configuration;

namespace BusinessLayer.DataLinkLayer
{
    public static class AppConfigProperty
    {
        public static readonly String TuitionConnectionString = "tuition.connectionString";
        public static readonly String TuitionLocalEnvoirnment = "tuition.ui.envoirnment";
        public static readonly String TuitionUiBaseUrl = "tuition.ui.base.url";
        public static readonly String TuitionLogPath = "tuition.log.file.path";
        public static readonly String TuitionMailFrom = "tuition.mail.from";
        public static readonly String TuitionMailPassword = "tuition.mail.password";
        public static readonly String TuitionMailHost = "tuition.mail.host";
        public static readonly String TuitionMailName = "tuition.mail.name";
        public static readonly String TuitionMailPort = "tuition.mail.port";
     
        public static int GetIntProperty(String property, int defaultValue)
        {
            if (ConfigurationManager.AppSettings[property] != null)
            {
                // Set log file path to the value specified in App.Config
                String strValue = ConfigurationManager.AppSettings[property];
                int intValue;
                bool isNumber = int.TryParse(strValue, out intValue);
                if (isNumber)
                {
                    return intValue;
                }
            }
            //Unable to get value, return default value
            return defaultValue;
        }

        public static bool HasProperty(String property)
        {
            return (ConfigurationManager.AppSettings[property] != null);
        }

        public static String GetStringProperty(String property)
        {
            return GetStringProperty(property, null);
        }

        public static String GetStringProperty(String property, String defaultValue)
        {

            if (ConfigurationManager.AppSettings[property] != null)
            {
                // Set log file path to the value specified in App.Config
                String strValue = ConfigurationManager.AppSettings[property];                
                return strValue;
            }
            //Unable to get value, return default value
            return defaultValue;
        }

       public static String GetConnectionProperty(String property)
        {
            String strValue = String.Empty;
            if (ConfigurationManager.ConnectionStrings[property] != null)
            {               
                 strValue = ConfigurationManager.ConnectionStrings[property].ToString();

            }
            return strValue;
        }

           
    }
}
