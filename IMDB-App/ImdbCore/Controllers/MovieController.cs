using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ImdbCore.Data.Abstract;
using ImdbCore.Data.Concrete.EfCore;
using ImdbCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImdbCore.Controllers
{
    public class MovieController : Controller
    {

        private DataContext context;
        public MovieController(DataContext _context)
        {
            context = _context;
        }
       
        public IActionResult Index(string arananMovie)
        {
            context.Ratings.RemoveRange(context.Ratings);
            context.Movies.RemoveRange(context.Movies);
            arananMovie = context.KeyWords.Select(x=>x.arananMovie).FirstOrDefault().ToString();
            arananMovie.Trim();
            if (arananMovie.Contains(" "))
            {
                arananMovie.Replace(" ", "+");
            }
            string urlSerie = "http://www.omdbapi.com/?t=" + arananMovie + "&apikey=c002cb14";
            HttpWebRequest requestMovie = WebRequest.Create(urlSerie) as HttpWebRequest;
            string jsonVerisi = "";
            using (HttpWebResponse response = requestMovie.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                //jsonVerisi adlı değişkene elde ettiği veriyi atıyoruz.
                jsonVerisi = reader.ReadToEnd();
                Movie movies = Newtonsoft.Json.JsonConvert.DeserializeObject<Movie>(jsonVerisi);
                if (movies.Title != null )
                {
                    context.Movies.Add(movies);

                }
               
            }
            context.SaveChanges();
            var model = context.Movies.Include(x => x.Ratings).FirstOrDefault();
            return View(model);

        }
        public IActionResult Details(int id)
        {
            var model = context.Movies.Include(x => x.Ratings).FirstOrDefault(x => x.Id == id);
            return View(model);
        }
    }
}