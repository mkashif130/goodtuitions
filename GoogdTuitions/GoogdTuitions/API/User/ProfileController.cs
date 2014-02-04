using System.Web.Http.Results;
using BusinessLayer.Processors.User;
using DataAccessLayer.User;
using System.Collections.Generic;
using System.Web.Http;

namespace GoogdTuitions.API.User
{
    public class ProfileController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet]
        [ActionName("GetProfile")]
        public JsonResult<ProfileEntity> Get(string id)
        {
            var profileProcssor = new ProfileProcessor();
            return Json(profileProcssor.GetSingle(id));
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
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