using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace ELabs.Controllers
{
    public class BuildsController : ApiController
    {
        private Models.Builds builds;

        public BuildsController()
        {
            this.builds = new Models.Builds();
        }
        // GET api/<controller>
        [Route("builds")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                List<edificio> buildsList = builds.GetBuilds();
                return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(buildsList));
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        // GET: api/Builds/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Builds
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Builds/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Builds/5
        public void Delete(int id)
        {
        }
    }
}
