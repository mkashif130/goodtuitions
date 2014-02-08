using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using BusinessLayer.Processors.Email;
using BusinessLayer.Response;
using DataAccessLayer.Email;
using DataAccessLayer.Response;
using System.Net.Http;
using DataAccessLayer.Login;

namespace GoogdTuitions.API.Auth
{
    public class VerificationTokenController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpPost]
        [ActionName("GetTokenVerify")]
        public HttpResponseMessage PostResetPassword([FromBody]PasswordResetEntity passwordReset)
        {
            try
            {
                var processor = new VerificationTokenProcessor();
                return processor.Verify(passwordReset);
            }
            catch (Exception)
            {
                return HttpExceptionResponse.UnknownError;
            }
        }

        // POST api/<controller>
        [HttpPost]
        [ActionName("Forgot")]
        public HttpResponseMessage PostVerificationToken([FromBody]VerificationTokenEntity verificationToken)
        {
            try
            {
                var processor = new VerificationTokenProcessor();
                return processor.Send(verificationToken);
            }
            catch (Exception)
            {
                return HttpExceptionResponse.UnknownError;
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}