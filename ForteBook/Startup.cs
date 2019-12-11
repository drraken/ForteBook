using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForteBook.Startup))]
namespace ForteBook

{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
