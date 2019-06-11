using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullStackMVC5.Startup))]
namespace FullStackMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
