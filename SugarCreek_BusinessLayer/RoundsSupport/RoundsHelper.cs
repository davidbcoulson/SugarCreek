using SugarCreek_BusinessLayer.Models;
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
        public static Round CreateRound(Guid teeTimeId, int numberOfHoles)
        {
            Round round = new Round
            {
                NumberOfHoles = numberOfHoles,
                Id = Guid.NewGuid(),
                CartId = Guid.NewGuid(),
                TeeTimeId = teeTimeId

            };


            using (SugarCreekEntities db = new SugarCreekEntities())
            {
                db.Rounds.Add(round);
                db.SaveChanges();

            }
            return round;
        }

        public static void CreateTeeTime(TeeTime tt)
        {
            using (SugarCreekEntities db = new SugarCreekEntities())
            {
                db.TeeTimes.Add(tt);
                db.SaveChanges();
            }
        }

        public static void CreateRoundMapper(Guid roundId, string golferId)
        {
            using (SugarCreekEntities db = new SugarCreekEntities())
            {
                var golfer = db.Golfers.Where(x => x.UserId == golferId).FirstOrDefault();

                RoundMapper roundMapper = new RoundMapper
                {
                    Id = Guid.NewGuid(),
                    GolferId = golfer.Id,
                    RoundId = roundId
                };


                db.RoundMappers.Add(roundMapper);
                db.SaveChanges();
            }

        }

        public static List<GolfRound> GetRounds(string golferId)
        {
            List<GolfRound> rounds = new List<GolfRound>();
            using (SugarCreekEntities db = new SugarCreekEntities())
            {
                var golfer = db.Golfers.Where(x => x.UserId == golferId).FirstOrDefault();
                var mappers = db.RoundMappers.Include("Round").Where(x => x.GolferId == golfer.Id).ToList();
                foreach (var item in mappers)
                {
                    GolfRound gr = new GolfRound()
                    {
                        NumberOfHoles = item.Round.NumberOfHoles.Value,
                        StartTime = item.Round.TeeTime.StartTime.Value
                    };
                    rounds.Add(gr);
                }
                return rounds;
            }
        }
    }
}
