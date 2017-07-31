using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReportsForOZHIdev.Startup))]
namespace ReportsForOZHIdev
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
