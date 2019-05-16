using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbCore.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Value { get; set; }

        public Serie Series { get; set; }
        public Episodes Episodes { get; set; }

        public Movie Movies { get; set; }
    }
}
