using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bur.Startup))]
namespace bur
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
