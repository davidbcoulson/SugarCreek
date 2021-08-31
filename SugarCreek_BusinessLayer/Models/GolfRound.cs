using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarCreek_BusinessLayer.Models
{
    public class GolfRound
    {
        public DateTime StartTime { get; set; }
        public int NumberOfHoles { get; set; }
        public int NumberOfBookedGolfers { get; set; }
        public int RemainingOpenings { get; set; }
    }
}
