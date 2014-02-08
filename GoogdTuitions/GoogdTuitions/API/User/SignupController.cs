using System;
using System.Net.Http;
using BusinessLayer.Processors.Signup;
using BusinessLayer.Response;
using DataAccessLayer.Signup;
using System.Collections.Generic;
using System.Web.Http;

namespace GoogdTuitions.API.User
{
    public class SignupController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet]
        [ActionName("GetUser")]
        public string Get(int id)
        {
            return "Value";
        }

        // POST api/<controller>
        [HttpPost]
        [ActionName("AddNewUser")]
        public HttpResponseMessage PostAddNewUser([FromBody]SignupEntity signup)
        {
            try
            {
                var processor = new SignupProcessor();
                return processor.Save(signup);
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
public class Test
{
    public string Id { get; set; }
}