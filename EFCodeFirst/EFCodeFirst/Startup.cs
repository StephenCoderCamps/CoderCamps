using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFCodeFirst.Startup))]
namespace EFCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
