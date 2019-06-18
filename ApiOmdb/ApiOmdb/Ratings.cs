using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiOmdb
{
    public class Ratings
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Value { get; set; }
        public Bolumler Bolumler { get; set; }
    }
}
