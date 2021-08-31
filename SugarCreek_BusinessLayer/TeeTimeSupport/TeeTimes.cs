using SugarCreek_BusinessLayer.Models;
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
            using (GolfingEntities db = new GolfingEntities())
            {
                db.TeeTimes.Add(teetime);
                db.SaveChanges();

            }

        }

        public static List<TeeTimeOption> GetFutureTeeTimes(DateTime date) 
        {
            List<TeeTimeOption> final = new List<TeeTimeOption>();

            TimeSpan start = new TimeSpan(6, 30, 0); //6:30 o'clock
            DateTime startTime = date.Date + start;

            TimeSpan end = new TimeSpan(19, 0, 0); //7 o'clock
            DateTime endTime = date.Date + end;
            int golfers = 0;

            List<TeeTime> established = new List<TeeTime>();
            using (GolfingEntities db = new GolfingEntities())
            {
                // will get you the tee times for this day
                established = db.TeeTimes.Include("Rounds").Where(x => x.StartTime.Value.Date == startTime.Date).ToList();
            }

            while (startTime < endTime)
            {
                var found = established.Where(x => x.StartTime.Value.TimeOfDay == startTime.TimeOfDay).FirstOrDefault();
                if (found == null)
                {
                    //add it to the list
                    TeeTimeOption tt = new TeeTimeOption() { Id = Guid.NewGuid(), StartTime = startTime, ActiveGolfers = 0 };
                    final.Add(tt);
                }
                else {
                    // create the class from what you found and add it to the final list
                    TeeTimeOption tt = new TeeTimeOption() { Id = found.Id, StartTime = found.StartTime.Value, ActiveGolfers = found.Rounds.Count() };
                    final.Add(tt);
                }
          
                
                startTime = startTime.AddMinutes(15);
            }
            return final;

        }


        public static List<TeeTimeOption> GetDailyTeeTimes()
        {
            List<TeeTimeOption> final = new List<TeeTimeOption>();

            DateTime currentDateTime = DateTime.Now;

            TimeSpan start = new TimeSpan(6, 30, 0); //6:30 o'clock
            DateTime startTime = currentDateTime.Date + start;

            TimeSpan moment = DateTime.Now.TimeOfDay;

            TimeSpan end = new TimeSpan(19, 0, 0); //7 o'clock
            DateTime endTime = currentDateTime.Date + end;
            int golfers = 0;
            if (moment > start && moment < end) 
            {
                while (startTime < endTime)
                {
                    using (GolfingEntities db = new GolfingEntities()) 
                    {
                        // this is wrong 
                        var established = db.TeeTimes.Where(x => x.StartTime == startTime).FirstOrDefault();
                        if (established != null) 
                        {
                            //someone has a tee time set in the system so lets get the round now
                        
                            golfers = db.Rounds.Where(x => x.TeeTimeId == established.Id).Count();
                        }
                    }
                    
                    TeeTimeOption tt = new TeeTimeOption() { Id = Guid.NewGuid(), StartTime = startTime.AddMinutes(15), ActiveGolfers = golfers };
                    //Console.WriteLine(startTime.ToShortTimeString() + " - " + startTime.AddMinutes(15).ToShortTimeString());
                    final.Add(tt);
                    startTime = startTime.AddMinutes(15);
                }
            
            }

            return final;
        }

    }
}
