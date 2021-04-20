using SugarCreek_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarCreek_BusinessLayer.RoundsSupport
{
    public class RoundsHelper
    {
       public static void CreateRound(Round round)
        {
            using (SugarCreekEntities db = new SugarCreekEntities())
            {
                db.Rounds.Add(round);
                db.SaveChanges();

            }

        }

        public static void CreateTeeTime(TeeTime tt) 
        {
            using (SugarCreekEntities db = new SugarCreekEntities())
            {
                db.TeeTimes.Add(tt);
                db.SaveChanges();
            }
        }




    }
}
