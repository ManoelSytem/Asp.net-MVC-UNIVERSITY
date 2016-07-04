using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManoelSystemMVC.Startup))]
namespace ManoelSystemMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
