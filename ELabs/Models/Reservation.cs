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
                    return db.reserva.ToList();
                }
            }
            catch (Exception e)
            {
                throw new System.ArgumentException(e.Message);
            }
        }
    }
}