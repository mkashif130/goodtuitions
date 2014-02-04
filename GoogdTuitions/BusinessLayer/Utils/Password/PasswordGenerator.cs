using System.Web.Security;

namespace BusinessLayer.Utils.Password
{
    /// <summary>
    /// This class will Encrypt the passwords
    /// <Author>Muhammad Arslan</Author>
    /// <Dated>26-Jan-2014</Dated>
    /// </summary>
    public class PasswordGenerator
    {

        #region Methods

        /// <summary>
        /// This method will return encrypted password
        /// </summary>
        /// <param name="plainPassword"></param>
        /// <param name="salt"> </param>
        /// <returns></returns>
        public static string EncryptPassword(string plainPassword, string salt)
        {
            string hashPassword = GetHashPassword(plainPassword+salt);
            return hashPassword;
        }

        /// <summary>
        /// This method will return hash of password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string GetHashPassword(string password)
        {
#pragma warning disable 612,618
            string hashPassowrd = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "sha1");
#pragma warning restore 612,618
            return hashPassowrd;
        }
        #endregion
    }
}
