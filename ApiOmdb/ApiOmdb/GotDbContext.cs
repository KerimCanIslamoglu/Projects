using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiOmdb
{
    public class GotDbContext:DbContext
    {
        public GotDbContext():base("GotContext")
        {

        }
        public DbSet<Bolumler> Bolumlers { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
    }
}
