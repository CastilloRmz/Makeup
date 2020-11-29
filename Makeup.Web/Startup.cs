using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Makeup.Web.Startup))]
namespace Makeup.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
