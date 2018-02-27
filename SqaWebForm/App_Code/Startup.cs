using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SqaWebForm.Startup))]
namespace SqaWebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
