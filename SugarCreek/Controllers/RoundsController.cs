using SugarCreek.Models;
using SugarCreek_BusinessLayer.Models;
using SugarCreek_BusinessLayer.RoundsSupport;
using SugarCreek_DataLayer;
using System;
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

                //Round round = new Round { 
                //NumberOfHoles = request.NumberOfHoles,
                //Id = teeTime.Id,

                //}

                try {
                    RoundsHelper.CreateTeeTime(teeTime);
                    //RoundsHelper.CreateRound(teeTime.Id, request.NumberOfHoles)
                }
                catch (Exception ex) 
                {
                    return null;
                }


            }
            return null;
            
        }

    }
}
