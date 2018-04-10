using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dogs_site.Startup))]
namespace Dogs_site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
