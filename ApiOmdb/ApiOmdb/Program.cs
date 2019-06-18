using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Data.Entity;

namespace ApiOmdb
{
    class Program
    {
        static void Main(string[] args)
        {
            DeleteData();
            Database();
            Console.WriteLine("Kayıt başarılı");
            //Console.ReadKey();
        }
        public static void DeleteData()
        {
            var _db = new GotDbContext();

            _db.Bolumlers.RemoveRange(_db.Bolumlers);
            _db.Ratings.RemoveRange(_db.Ratings);
            _db.SaveChanges();
        }

        public static void Database()
        {
            GotDbContext db = new GotDbContext();
            for (int j = 1; j < 9; j++)
            {
                for (int i = 1; i < 11; i++)
                {
                    string url = "http://www.omdbapi.com/?t=Game%20of%20Thrones&Season=" + j + "&Episode=" + i + "&apikey=c002cb14";

                    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                    string jsonVerisi = "";
                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        //jsonVerisi adlı değişkene elde ettiği veriyi atıyoruz.
                        jsonVerisi = reader.ReadToEnd();
                        Bolumler bolumlers = Newtonsoft.Json.JsonConvert.DeserializeObject<Bolumler>(jsonVerisi);

                        if (bolumlers.Title != null)
                        {
                            db.Bolumlers.Add(bolumlers);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}