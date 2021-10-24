using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Abashkin_Denis_MDM_171_333
{
    class ApplicationContext : DbContext
    {           
        public DbSet<User> Users { get; set; }
        public DbSet<Postavhik> Postavhiks { get; set; }
        public DbSet<Towar> Towars { get; set; }
        public DbSet<Zakaz> Zakazs { get; set; }
        public ApplicationContext() : base("DefaultConnection") { }        
    }
}
