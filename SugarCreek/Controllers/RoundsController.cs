using Microsoft.AspNet.Identity;
using SugarCreek.Models;
using SugarCreek_BusinessLayer.Models;
using SugarCreek_BusinessLayer.RoundsSupport;
using SugarCreek_DataLayer;
using System;
using System.Collections.Generic;
using System.Web.Http;
using SugarCreek_BusinessLayer.TeeTimeSupport;

namespace SugarCreek.Controllers
{
    public class RoundsController : ApiController
    {
        [Route("api/rounds/createRound")]
        [HttpPost]
        [Authorize]
        public GolfRound CreateGolfRound([FromBody] TeeTimeRequest request )
        {
            if (request != null)
            {
                TeeTime teeTime = new TeeTime
                {
                    Id = Guid.NewGuid(),
                    StartTime = request.TeeTime
                };

               
                try {
                    RoundsHelper.CreateTeeTime(teeTime);
                    var round = RoundsHelper.CreateRound(teeTime.Id, request.NumberOfHoles);
                    RoundsHelper.CreateRoundMapper(round.Id, User.Identity.GetUserId());
                }
                catch (Exception ex) 
                {
                    return null;
                }


            }
            return null;
            
        }

        [Route("api/rounds/getRounds")]
        [HttpGet]
        [Authorize]

        public List<GolfRound> GetUsersRounds()
        {
            return RoundsHelper.GetRounds(User.Identity.GetUserId());
        }


        [Route("api/rounds/getOpenRounds")]
        [HttpGet]
        [Authorize]

        public List<TeeTimeOption> GetTodaysOpenRounds()
        {
            return TeeTimes.GetDailyTeeTimes();
        }

    }
}
