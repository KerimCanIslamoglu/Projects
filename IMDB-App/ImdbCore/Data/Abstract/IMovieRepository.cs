using ImdbCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbCore.Data.Abstract
{
    interface IMovieRepository
    {
        IEnumerable<Movie> GetMovieByName(string arananMovie);
    }
}
