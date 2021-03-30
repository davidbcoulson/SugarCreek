using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SugarCreek.Controllers
{
    [Authorize]
    public class AdminController : ApiController
    {
        // TO DO: Add role security for Admin Only.
        [HttpGet]
        public string ConnectionTest() 
        {
            return "connection made";
        }
    }
}
