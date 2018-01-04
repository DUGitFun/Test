using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Allowance.Web.Startup))]
namespace Allowance.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
