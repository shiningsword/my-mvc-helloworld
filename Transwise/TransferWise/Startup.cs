using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TransferWise.Startup))]
namespace TransferWise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
