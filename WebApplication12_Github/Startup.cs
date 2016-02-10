using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication12_Github.Startup))]
namespace WebApplication12_Github
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
