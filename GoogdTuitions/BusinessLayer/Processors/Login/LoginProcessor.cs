using BusinessLayer.Repository.Login;
using BusinessLayer.Utils.Password;
using DataAccessLayer.Response;

namespace BusinessLayer.Processors.Login
{
    public class LoginProcessor
    {
        public ResponseMessages Login(string userId, string password)
        {
            var loginRepository = new LoginRepository();
            var resp = new ResponseMessages();
            var login = loginRepository.GetSingle(userId);
            if (login != null && (login.PasswordHash != null && (login.PasswordHash.Equals(PasswordGenerator.EncryptPassword(password, login.PasswordSalt)))))
            {
                resp.Message = ResponseMessages.Success;
            }
            else
            {
                resp.Message = ResponseMessages.Error;
            }
            return resp;
        }
    }
}
