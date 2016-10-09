using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Xin.Web.Startup))]
namespace Xin.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
