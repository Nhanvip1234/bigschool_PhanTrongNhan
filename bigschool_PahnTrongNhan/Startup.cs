using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bigschool_PahnTrongNhan.Startup))]
namespace bigschool_PahnTrongNhan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
