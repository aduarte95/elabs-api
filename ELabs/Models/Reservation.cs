using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELabs.Models
{
    public class Reservation
    {
        public List<reserva> GetReservas()
        {
            try
            {
                using (elabsDB db = new elabsDB())
                {
                    return db.reserva.Include("laboratorio").Include("usuario").ToList();
                }
            }
            catch (Exception e)
            {
                throw new System.ArgumentException(e.Message);
            }
        }

        public List<reserva> GetReservasByHour(int hour,int day,int month, int year)
        {
            try
            {
                using (elabsDB db = new elabsDB())
                {
                    return db.reserva.Include("laboratorio").Where(r=> r.fecha_inicio.Year == year && r.fecha_inicio.Month == month && r.fecha_inicio.Day == day
                    && r.fecha_inicio.Hour == hour && r.estado == true).ToList();
                }
            }
            catch (Exception e)
            {
                throw new System.ArgumentException(e.Message);
            }
        }
    }
}