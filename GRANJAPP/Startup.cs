using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GRANJAPP.Startup))]
namespace GRANJAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
