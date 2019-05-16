using ApiOmdb;

using GotCoreApp.Data.Abstract;
using GotCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotCoreApp.Data.Concrete
{
    public class EfEpisodesRepository : IEpisodesRepository
    {
        private GotDbConsoleContext context;
        public EfEpisodesRepository(GotDbConsoleContext _context)
        {
            context = _context;
        }

        //public IEnumerable<Bolumler> GetBySeason(int seasonId)
        //{
          
        //}

       
    }
}
