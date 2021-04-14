using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SugarCreek.Models
{
    public class IncomingRoundRequest
    {
        public DateTime TeeTime { get; set; }
        public int NumberOfHoles { get; set; }
        public bool Cart { get; set; }

    }
}