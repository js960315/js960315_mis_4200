using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(js960315_MIS4200.Startup))]
namespace js960315_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
