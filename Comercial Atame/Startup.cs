using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comercial_Atame.Startup))]
namespace Comercial_Atame
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
