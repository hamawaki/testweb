using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWebApplication.Startup))]
namespace AzureWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
