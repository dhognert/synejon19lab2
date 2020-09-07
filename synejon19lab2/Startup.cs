using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(synejon19lab2.Startup))]
namespace synejon19lab2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
