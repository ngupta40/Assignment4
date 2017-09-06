using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment4TryItApp.Startup))]
namespace Assignment4TryItApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
