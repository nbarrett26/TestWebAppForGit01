using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebAppForGit01.Startup))]
namespace TestWebAppForGit01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
