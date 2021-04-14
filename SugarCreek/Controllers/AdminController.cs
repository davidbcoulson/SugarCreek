using SugarCreek.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.Identity.EntityFramework;

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

        [Route("api/creategolfer")]
        [HttpPost]
        public async Task<bool> CreateGolfer([FromBody] string email)
        {
            try 
            {
                using (var context = new ApplicationDbContext())
                {
                    var userStore = new UserStore<ApplicationUser>(context);
                    var userManager = new Microsoft.AspNet.Identity.UserManager<ApplicationUser>(userStore);

                    var user = new ApplicationUser { UserName = email };
                    await userManager.CreateAsync(user);
                   // await userManager.AddToRoleAsync(user.Id, "Administrator");
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



    }
}
