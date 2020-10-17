using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Second_Session.Startup))]
namespace Second_Session
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
