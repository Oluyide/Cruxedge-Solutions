using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cruxedge_Solutions.Startup))]
namespace Cruxedge_Solutions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
