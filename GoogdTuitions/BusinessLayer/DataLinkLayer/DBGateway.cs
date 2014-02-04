using System;

namespace BusinessLayer.DataLinkLayer
{
    /// <summary>
    /// This class connects project to Database
    /// 
    /// </summary>
    public class DBGateway
    {
        public static String ConnectionString = AppConfigProperty.GetConnectionProperty(AppConfigProperty.TuitionConnectionString);
    }
}
