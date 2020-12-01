using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomOrders.WebMVC.Startup))]
namespace CustomOrders.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
