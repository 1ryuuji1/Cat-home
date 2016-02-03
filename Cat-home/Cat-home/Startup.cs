using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cat_home.Startup))]
namespace Cat_home
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
