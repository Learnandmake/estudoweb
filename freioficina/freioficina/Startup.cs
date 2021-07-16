using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(freioficina.Startup))]
namespace freioficina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
