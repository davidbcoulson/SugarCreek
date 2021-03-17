using SugarCreek_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarCreek_BusinessLayer.GolferSupport
{
    public class GolferHelper
    {
        public static Golfer FindGolfer(string userId)
        {
            using (SugarCreekEntities db = new SugarCreekEntities())
            {
                return db.Golfers.Where(x => x.UserId == userId).FirstOrDefault();

            }  
        
        }

        public static void CreateGolfer(Golfer golfer)
        {
            using (SugarCreekEntities db = new SugarCreekEntities())
            {
                db.Golfers.Add(golfer);
                db.SaveChanges();
               
            }

        }

    }
}
