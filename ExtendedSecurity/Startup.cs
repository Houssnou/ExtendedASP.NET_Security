using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExtendedSecurity.Startup))]
namespace ExtendedSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
