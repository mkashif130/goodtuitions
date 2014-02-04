using System;
using System.Net;
using System.Net.Http;
using BusinessLayer.Processors.Signup;
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
        public HttpResponseMessage AddNewUser([FromBody]SignupEntity signup)
        {
            var processor = new SignupProcessor();
            try
            {
                processor.Save(signup);
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            catch (Exception exception)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                               {
                                   Content = new StringContent(exception.ToString())
                               };
                throw new HttpResponseException(resp);
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