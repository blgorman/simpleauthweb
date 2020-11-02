using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleAuthWeb.Startup))]
namespace SimpleAuthWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
