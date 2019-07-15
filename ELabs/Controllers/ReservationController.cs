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
                return Request.CreateResponse(HttpStatusCode.OK, reservation.GetReservas());
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        [Route("reservas/{year}/{month}/{day}/{hour}")]
        [HttpGet]
        public HttpResponseMessage GetReservationsByDate(int year,int month, int day, int hour)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, reservation.GetReservasByHour(hour,day,month,year));
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

    }
}
