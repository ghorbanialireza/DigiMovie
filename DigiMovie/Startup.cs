using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigiMovie.Startup))]
namespace DigiMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
