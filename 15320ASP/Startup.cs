using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_15320ASP.Startup))]
namespace _15320ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
