using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamerNews.WebMVC.Startup))]
namespace GamerNews.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
