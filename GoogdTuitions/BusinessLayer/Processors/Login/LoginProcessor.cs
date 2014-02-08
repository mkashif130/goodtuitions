using System.Net;
using System.Net.Http;
using BusinessLayer.Repository.Login;
using BusinessLayer.Response;
using BusinessLayer.Utils.Password;

namespace BusinessLayer.Processors.Login
{
    public class LoginProcessor
    {
        public HttpResponseMessage Login(string userId, string password)
        {
            var loginRepository = new LoginRepository();
            var login = loginRepository.GetSingle(userId);
            if (login != null && (login.PasswordHash != null && (login.PasswordHash.Equals(PasswordGenerator.EncryptPassword(password, login.PasswordSalt)))))
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return login == null ? HttpExceptionResponse.UserNotFound : HttpExceptionResponse.InvalidPassword;
        }
    }
}
