using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcmusicstore.Startup))]
namespace mvcmusicstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
