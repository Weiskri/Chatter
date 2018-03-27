using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatterTwo.Startup))]
namespace ChatterTwo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
