using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AMillionLittleThings.WebMVC.Startup))]
namespace AMillionLittleThings.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
