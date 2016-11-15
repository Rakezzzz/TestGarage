using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGarage.Startup))]
namespace TestGarage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
