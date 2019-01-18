using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BookApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API の設定およびサービス

            // Web API ルート
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "GetBooks",
                routeTemplate: "api/v1/Book/GetBooks",
                defaults: new
                {
                    controller = "Book",
                    action = "GetBooks"
                }
            );
        }
    }
}
