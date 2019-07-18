using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TS.BAPLN.UI.Startup))]
namespace TS.BAPLN.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
