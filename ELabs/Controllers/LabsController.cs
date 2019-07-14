using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ELabs.Controllers
{
    public class LabsController : ApiController
    {
        private Models.Labs lab;

        public LabsController()
        {
            this.lab = new Models.Labs();
        }
        [Route("labs")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                List<laboratorio> labsList = lab.GetLaboratorios();
                return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(labsList));
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }
    }
}
