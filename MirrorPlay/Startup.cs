using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MirrorPlay.Startup))]
namespace MirrorPlay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
