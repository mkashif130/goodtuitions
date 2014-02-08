using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Processors.Login;
using BusinessLayer.Response;
using DataAccessLayer.Login;

namespace GoogdTuitions.API.Auth
{
    public class AuthController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "Value";
        }

        // POST api/<controller>
        [HttpPost]
        [ActionName("GetLogin")]
        public HttpResponseMessage PostLogin([FromBody]LoginEntity login)
        {
            try
            {
                var loginProcessor = new LoginProcessor();
                return loginProcessor.Login(login.EmailAddress, login.Password);
            }
            catch(Exception)
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