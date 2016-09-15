using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PAPERSOLUTION.Startup))]
namespace PAPERSOLUTION
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
