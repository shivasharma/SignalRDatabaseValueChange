using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRDatabaseValueChanges.Startup))]
namespace SignalRDatabaseValueChanges
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
