using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(INDOVO.Startup))]
namespace INDOVO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
