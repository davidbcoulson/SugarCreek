using SugarCreek_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarCreek_BusinessLayer.TeeTimeSupport
{
    public class TeeTimes
    {
        public static void CreateTeeTime(TeeTime teetime)
        {
            using (SugarCreekEntities db = new SugarCreekEntities())
            {
                db.TeeTimes.Add(teetime);
                db.SaveChanges();

            }

        }

    }
}
