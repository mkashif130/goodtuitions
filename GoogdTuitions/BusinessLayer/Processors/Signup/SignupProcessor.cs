using System.Net;
using BusinessLayer.Repository.Signup;
using BusinessLayer.Response;
using DataAccessLayer.Response;
using DataAccessLayer.Signup;
using System.Net.Http;
namespace BusinessLayer.Processors.Signup
{
    public class SignupProcessor
    {
        public HttpResponseMessage Save(SignupEntity signup)
        {
            var mainRepository = new SignupRepository();
            var response= mainRepository.Save(signup);
            if (response == ResponseMessages.Created)
            {
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            if (response == ResponseMessages.NetworkError)
            {
                return HttpExceptionResponse.NetworkError;
            }
            return response == ResponseMessages.AlreadyExist ? HttpExceptionResponse.UserAlreadyExists : HttpExceptionResponse.UnknownError;
        }
    }
}
