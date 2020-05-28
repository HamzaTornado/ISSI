using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISSI.Startup))]
namespace ISSI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
