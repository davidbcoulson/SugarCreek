using SugarCreek.Models;
using SugarCreek_BusinessLayer.Models;
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
            return null;

        }

    }
}
