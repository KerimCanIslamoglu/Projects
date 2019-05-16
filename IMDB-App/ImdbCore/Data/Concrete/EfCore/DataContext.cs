using ImdbCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbCore.Data.Concrete.EfCore
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        { 
            
        }
        public DbSet<Episodes> Episodes { get; set; }
        public DbSet<KeyWords> KeyWords { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<SeasonEpisodes> SeasonEpisodes { get; set; }
        public DbSet<Seasons> Seasons { get; set; }
        public DbSet<Serie> Series { get; set; }
    }
}
