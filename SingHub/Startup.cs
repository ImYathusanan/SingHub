using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SingHub.Startup))]
namespace SingHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
