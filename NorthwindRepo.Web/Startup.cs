using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindRepo.Web.Startup))]
namespace NorthwindRepo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
