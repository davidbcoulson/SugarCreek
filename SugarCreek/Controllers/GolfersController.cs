using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SugarCreek.Controllers
{
    public class GolfersController : ApiController
    {
        [HttpGet]
        public string ConnectionTest()
        {
            return "connection made";
        }
    }
}
