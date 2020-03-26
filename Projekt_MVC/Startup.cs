using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projekt_MVC.Startup))]
namespace Projekt_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
