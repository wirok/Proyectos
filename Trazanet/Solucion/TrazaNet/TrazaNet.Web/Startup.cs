using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrazaNet.Web.Startup))]
namespace TrazaNet.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
