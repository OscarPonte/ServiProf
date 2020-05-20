using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiProf.Startup))]
namespace ServiProf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
