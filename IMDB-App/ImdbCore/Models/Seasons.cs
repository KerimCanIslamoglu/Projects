using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbCore.Models
{
    public class Seasons
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Season { get; set; }
        public int totalSeasons { get; set; }
        public List<SeasonEpisodes> SeasonEpisodesS { get; set; }
        public bool Response { get; set; }
    }
}
