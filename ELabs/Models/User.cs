using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELabs.Models
{
    public class User
    {
        public List<usuario> GetUsuarios()
        {
            try
            {
                using (elabsDB db = new elabsDB())
                {
                    return db.usuario.ToList();
                }
            }
            catch(Exception e)
            {
                throw new System.ArgumentException(e.Message);
            }
        }
    }
}