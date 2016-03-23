using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Part2Demo.Startup))]
namespace Part2Demo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
