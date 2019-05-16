using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ImdbCore.Data.Concrete.EfCore;
using ImdbCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImdbCore.Controllers
{
    public class SerieController : Controller
    {
        private DataContext context;
        public SerieController(DataContext _context)
        {
            context = _context;
        }
        public IActionResult Index(string arananSerie)
        {
            context.Ratings.RemoveRange(context.Ratings);
            context.Series.RemoveRange(context.Series);
            context.Seasons.RemoveRange(context.Seasons);
            context.SeasonEpisodes.RemoveRange(context.SeasonEpisodes);
            context.Episodes.RemoveRange(context.Episodes);

            arananSerie = context.KeyWords.Select(x => x.arananSerie).FirstOrDefault().ToString();
            arananSerie.Trim();
            if (arananSerie.Contains(" "))
            {
                arananSerie.Replace(" ", "+");
            }

            string urlSerie = "http://www.omdbapi.com/?t=" + arananSerie + "&apikey=c002cb14";
            HttpWebRequest requestSerie = WebRequest.Create(urlSerie) as HttpWebRequest;
            string jsonVerisi = "";

            using (HttpWebResponse response = requestSerie.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                //jsonVerisi adlı değişkene elde ettiği veriyi atıyoruz.
                jsonVerisi = reader.ReadToEnd();

                Serie series = Newtonsoft.Json.JsonConvert.DeserializeObject<Serie>(jsonVerisi);

                if (series.Type == "series")
                {
                    context.Series.Add(series);
                }


                for (int i = 1; i <= series.totalSeasons; i++)
                {
                    string urlSeason = "http://www.omdbapi.com/?t=" + arananSerie + "&Season=" + i + "&apikey=c002cb14";
                    //Console.WriteLine(urlSeason);
                    HttpWebRequest requestSeason = WebRequest.Create(urlSeason) as HttpWebRequest;
                    string jsonVerisi2 = "";
                    using (HttpWebResponse response2 = requestSeason.GetResponse() as HttpWebResponse)
                    {
                        StreamReader reader2 = new StreamReader(response2.GetResponseStream());
                        //jsonVerisi adlı değişkene elde ettiği veriyi atıyoruz.
                        jsonVerisi2 = reader2.ReadToEnd();
                        Seasons seasons = Newtonsoft.Json.JsonConvert.DeserializeObject<Seasons>(jsonVerisi2);

                        SeasonEpisodes seasonEpisodes = Newtonsoft.Json.JsonConvert.DeserializeObject<SeasonEpisodes>(jsonVerisi2);

                        // Console.WriteLine(jsonVerisi2);,


                        context.Seasons.Add(seasons);
                        context.SeasonEpisodes.Add(seasonEpisodes);

                        //int episodesss = db.SeasonEpisodes.Select(x => x.Episode).Count();

                        for (int j = 1; j <= 30; j++) /// !!!!!??????????
                        {
                            string urlEpisode = "http://www.omdbapi.com/?t=" + arananSerie + "&Season=" + i + "&Episode=" + j + "&apikey=c002cb14";

                            HttpWebRequest requestEpisode = WebRequest.Create(urlEpisode) as HttpWebRequest;
                            string jsonVerisi3 = "";
                            using (HttpWebResponse response3 = requestEpisode.GetResponse() as HttpWebResponse)
                            {
                                StreamReader reader3 = new StreamReader(response3.GetResponseStream());
                                //jsonVerisi adlı değişkene elde ettiği veriyi atıyoruz.
                                jsonVerisi3 = reader3.ReadToEnd();

                                Episodes episodes = Newtonsoft.Json.JsonConvert.DeserializeObject<Episodes>(jsonVerisi3);
                                //Console.WriteLine(jsonVerisi3);
                                //episodes.Released = DateTime.Parse(episodes.Released.ToString());
                                if (episodes.Title != null)
                                {
                                    context.Episodes.Add(episodes);
                                }
                            }
                        }
                    }

                }
            }
            context.SaveChanges();

            var model = context.Series.Include(x => x.Ratings).FirstOrDefault();

            return View(model);
        }

        public IActionResult Seasons()
        {
            var model = context.Seasons.OrderByDescending(x=>x.Season);

            return View(model);
        }

        public IActionResult Episodes(int seasonId)
        {
            var model = context.Episodes.Include(x => x.Ratings).OrderBy(x => x.Season).ThenBy(x => x.Episode).Where(x=>x.Season==seasonId);
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var model = context.Episodes.Include(x => x.Ratings).FirstOrDefault(x => x.Id == id);
            return View(model);
        }
    }
}