using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MrWhiteLaundryBooker.Startup))]
namespace MrWhiteLaundryBooker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
