using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedecineAttente.Startup))]
namespace MedecineAttente
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
