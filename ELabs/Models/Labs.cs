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
    }
}