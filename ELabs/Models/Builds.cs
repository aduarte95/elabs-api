using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELabs.Models
{
    public class Builds
    {
        public List<edificio> GetBuilds()
        {
            try
            {
                using (elabsDB db = new elabsDB())
                {
                    return db.edificio.ToList();
                }
            }
            catch (Exception e)
            {
                throw new System.ArgumentException(e.Message);
            }
        }
    }
}