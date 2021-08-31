using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarCreek_BusinessLayer.Models
{
    public class TeeTimeRequest
    {
        public DateTime TeeTime { get; set; }
        public int NumberOfHoles { get; set; }
        public int NumberOfGolfers { get; set; }
        public bool Cart { get; set; }

    }
}
