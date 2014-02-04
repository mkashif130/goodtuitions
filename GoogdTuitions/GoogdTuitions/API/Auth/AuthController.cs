using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using BusinessLayer.Processors.Login;
using DataAccessLayer.Login;
using DataAccessLayer.Response;

namespace GoogdTuitions.API.Auth
{
    public class AuthController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new [] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "Value";
        }

        // POST api/<controller>
        [HttpPost]
        [ActionName("GetLogin")]
        public JsonResult<ResponseMessages> Post([FromBody]LoginEntity login)
        {
            var loginProcessor = new LoginProcessor();
            return Json(loginProcessor.Login(login.EmailAddress, login.Password));
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