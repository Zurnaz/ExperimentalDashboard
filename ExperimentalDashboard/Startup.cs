using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExperimentalDashboard.Startup))]
namespace ExperimentalDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
