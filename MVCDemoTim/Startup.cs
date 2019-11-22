using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDemoTim.Startup))]
namespace MVCDemoTim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
