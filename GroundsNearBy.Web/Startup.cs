using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroundsNearBy.Web.Startup))]
namespace GroundsNearBy.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
