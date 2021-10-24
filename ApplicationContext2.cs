using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Abashkin_Denis_MDM_171_333
{
    class ApplicationContext2 : DbContext
    {
        public DbSet<Storage> Storages { get; set; }
        public ApplicationContext2() : base("DefaultConnection2") { }
    }
}
