using System;
using System.Collections.Generic;

namespace GotCoreApp.Models
{
    public partial class Ratings
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Value { get; set; }
        public int? BolumlerId { get; set; }

        public Bolumlers Bolumler { get; set; }
    }
}
