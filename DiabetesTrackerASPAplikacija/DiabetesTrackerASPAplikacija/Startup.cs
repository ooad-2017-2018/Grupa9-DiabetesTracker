using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiabetesTrackerASPAplikacija.Startup))]
namespace DiabetesTrackerASPAplikacija
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
