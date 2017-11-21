using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcgit2.Startup))]
namespace mvcgit2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
