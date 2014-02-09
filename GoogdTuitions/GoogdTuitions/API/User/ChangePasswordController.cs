using System.Net.Http;
using BusinessLayer.Processors.User;
using BusinessLayer.Response;
using DataAccessLayer.User;
using System.Collections.Generic;
using System.Web.Http;

namespace GoogdTuitions.API.User
{
    public class ChangePasswordController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new [] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        [ActionName("ChangePassword")]
        public HttpResponseMessage Post([FromBody]ChangePasswordEntity changePassword)
        {
            try
            {
                var processor = new ChangePasswordProcessor();
                return processor.Update(changePassword);
            }
            catch
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