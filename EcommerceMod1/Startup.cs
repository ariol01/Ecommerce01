using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcommerceMod1.Startup))]
namespace EcommerceMod1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
