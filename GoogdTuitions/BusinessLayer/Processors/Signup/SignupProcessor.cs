using BusinessLayer.Repository.Signup;
using DataAccessLayer.Response;
using DataAccessLayer.Signup;
namespace BusinessLayer.Processors.Signup
{
    public class SignupProcessor
    {
        public string Save(SignupEntity signup)
        {
            var mainRepository = new SignupRepository();
            return mainRepository.Save(signup);
        }
    }
}
