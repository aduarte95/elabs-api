using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ELabs.Controllers
{
    public class UserController : ApiController
    {
        private Models.User user;

        public UserController()
        {
            this.user = new Models.User();
        }
        // GET api/<controller>
        [Route("usuarios")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                String html = "";
                foreach (usuario usr in user.GetUsuarios())
                {
                    html += usr.nombre + usr.correo + usr.contrasena + "\n";
                }
                return Request.CreateResponse(HttpStatusCode.OK, html);
            }
            catch(Exception e)
            {
                throw new ArgumentException(e.Message);
            }
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