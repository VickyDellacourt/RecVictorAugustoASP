using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecVictorAugustoASP.Startup))]
namespace RecVictorAugustoASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
