using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testowinii.Startup))]
namespace testowinii
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
