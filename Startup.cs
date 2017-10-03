using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureDemoTest.Startup))]
namespace AzureDemoTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
