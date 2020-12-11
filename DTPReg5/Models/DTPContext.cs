using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DTPReg5.Models
{
    public class DTPContext : DbContext
    {
    
        public DTPContext() : base("name=DTPContext")
        {
        }

        public System.Data.Entity.DbSet<DTPReg5.Models.Registration> Registrations { get; set; }
        public System.Data.Entity.DbSet<DTPReg5.Models.Type> Types { get; set; }
    }
}
