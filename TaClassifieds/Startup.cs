using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaClassifieds.Startup))]
namespace TaClassifieds
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //test
        }
    }
}
