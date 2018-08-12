using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IRISHELTHDEMO01.Startup))]
namespace IRISHELTHDEMO01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
