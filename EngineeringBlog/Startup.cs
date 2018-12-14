using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EngineeringBlog.Startup))]
namespace EngineeringBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
