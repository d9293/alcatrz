using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApiHost.Startup))]
namespace ApiHost
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
