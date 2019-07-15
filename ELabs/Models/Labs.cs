using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELabs.Models
{
    public class Labs
    {
        public List<laboratorio> GetLaboratorios()
        {
            try
            {
                using (elabsDB db = new elabsDB())
                {
                    return db.laboratorio.ToList();
                }
            }
            catch (Exception e)
            {
                throw new System.ArgumentException(e.Message);
            }
        }

        public List<laboratorio> GetLaboratoriosByBuild(string build)
        {
            try
            {
                using (elabsDB db = new elabsDB())
                {
                    return db.laboratorio.Where(l=>l.edificio.nombre == build).ToList();
                }
            }
            catch (Exception e)
            {
                throw new System.ArgumentException(e.Message);
            }
        }
    }
}