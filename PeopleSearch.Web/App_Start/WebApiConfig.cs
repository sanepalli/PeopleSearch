using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;

namespace PeopleSearch.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(
           new QueryStringMapping("type", "json", new MediaTypeHeaderValue("application/json")));

            /*Response as xml format depend on request type
             * http://localhost:9090/WebApp/api/user/?type=xml
             */
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.MediaTypeMappings.Add(
            new QueryStringMapping("type", "xml", new MediaTypeHeaderValue("application/xml")));

            /* Uncomment below to use convention based routing in addition to attribute routing
            */
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
