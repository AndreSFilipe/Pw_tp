using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PW_TP_1.Startup))]
namespace PW_TP_1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
