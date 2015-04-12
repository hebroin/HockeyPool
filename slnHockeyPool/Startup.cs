using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(slnHockeyPool.Startup))]
namespace slnHockeyPool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
