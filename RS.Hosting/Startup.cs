using System.Net.Http.Formatting;
using System.Web.Http;
using Owin;

namespace RS.Hosting
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            config.Routes.MapHttpRoute("DefaultApi", 
                "api/{controller}/{action}");

            app.UseWebApi(config);
        }
    }
}
