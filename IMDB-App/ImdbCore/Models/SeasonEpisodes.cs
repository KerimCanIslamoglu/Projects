using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbCore.Models
{
    public class SeasonEpisodes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Released { get; set; }
        public string Episode { get; set; }
        public string imdbRating { get; set; }
        public string imdbID { get; set; }
        public Seasons Seasons { get; set; }
    }
}
