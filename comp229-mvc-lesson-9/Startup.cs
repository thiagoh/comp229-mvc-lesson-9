using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comp229_mvc_lesson_9.Startup))]
namespace comp229_mvc_lesson_9 {
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
