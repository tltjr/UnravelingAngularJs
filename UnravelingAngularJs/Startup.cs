using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnravelingAngularJs.Startup))]
namespace UnravelingAngularJs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
