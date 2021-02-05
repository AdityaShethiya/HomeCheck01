using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeCheck.Startup))]
namespace HomeCheck
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
