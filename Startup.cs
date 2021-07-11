using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doctruyenchua.Startup))]
namespace Doctruyenchua
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
