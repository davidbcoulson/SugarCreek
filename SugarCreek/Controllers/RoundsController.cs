using Microsoft.AspNet.Identity;
using SugarCreek.Models;
using SugarCreek_BusinessLayer.Models;
using SugarCreek_BusinessLayer.RoundsSupport;
using SugarCreek_DataLayer;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace SugarCreek.Controllers
{
    public class RoundsController : ApiController
    {
        [Route("api/rounds/createRound")]
        [HttpPost]
        [Authorize]
        public GolfRound CreateGolfRound([FromBody] IncomingRoundRequest request )
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


    }
}
