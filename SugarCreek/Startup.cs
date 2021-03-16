using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SugarCreek.Startup))]
namespace SugarCreek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
