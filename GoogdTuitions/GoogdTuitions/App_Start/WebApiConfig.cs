using System.Web.Http;

namespace GoogdTuitions.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute("Signup", "api/user/{controller}/{action}", new
                {
                    symbol = RouteParameter.Optional,
                    controller = "Signup"
                }
            );
            config.Routes.MapHttpRoute("Auth", "api/auth/{controller}/{action}", new
                {
                    symbol = RouteParameter.Optional,
                    controller = "Auth"
                }
            );
        }
    }
}