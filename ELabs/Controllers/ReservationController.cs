using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ELabs.Controllers
{
    public class ReservationController : ApiController
    {
        private Models.Reservation reservation;

        public ReservationController()
        {
            this.reservation = new Models.Reservation();
        }
        // GET api/<controller>
        [Route("reservas")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                String html = "";
                foreach (reserva reserva in )
                {
                    html += reserva.fecha_fin + "\n";
                }
                return Request.CreateResponse(HttpStatusCode.OK, reservation.GetReservas());
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        // GET: api/Reservation/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Reservation
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Reservation/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Reservation/5
        public void Delete(int id)
        {
        }
    }
}
