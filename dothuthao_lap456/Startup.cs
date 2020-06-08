using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dothuthao_lap456.Startup))]
namespace dothuthao_lap456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
