using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFirstApp.Startup))]
namespace MVCFirstApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
