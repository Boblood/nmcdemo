using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nmcdemo.Startup))]
namespace nmcdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
