using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab01_CloudTechnologies.Startup))]
namespace Lab01_CloudTechnologies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
