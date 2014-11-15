using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UVGProject.Startup))]
namespace UVGProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
