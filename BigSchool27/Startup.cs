using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool27.Startup))]
namespace BigSchool27
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
