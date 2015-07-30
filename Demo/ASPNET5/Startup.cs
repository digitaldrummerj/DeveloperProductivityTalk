using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNET5.Startup))]
namespace ASPNET5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
