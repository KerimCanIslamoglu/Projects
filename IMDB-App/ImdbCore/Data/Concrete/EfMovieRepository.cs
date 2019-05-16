using ImdbCore.Data.Abstract;
using ImdbCore.Data.Concrete.EfCore;
using ImdbCore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ImdbCore.Data.Concrete
{
    public class EfMovieRepository : IMovieRepository
    {
        private DataContext context;
        public EfMovieRepository(DataContext _context)
        {
            context = _context;
        }

        public IEnumerable<Movie> GetMovieByName(string arananMovie)
        {
            arananMovie.Trim();
            if (arananMovie.Contains(" "))
            {
                arananMovie.Replace(" ", "+");
            }
            string urlSerie = "http://www.omdbapi.com/?t=" + arananMovie + "&apikey=c002cb14";
            HttpWebRequest requestSerie = WebRequest.Create(urlSerie) as HttpWebRequest;
            string jsonVerisi = "";
            using (HttpWebResponse response = requestSerie.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                //jsonVerisi adlı değişkene elde ettiği veriyi atıyoruz.
                jsonVerisi = reader.ReadToEnd();
                Movie movies = Newtonsoft.Json.JsonConvert.DeserializeObject<Movie>(jsonVerisi);
                if (movies.Title != null)
                {
                    context.Movies.Add(movies);
                }
                context.SaveChanges();
            }
            return context.Movies;
        }
    }
}
