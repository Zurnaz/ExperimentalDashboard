using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExperimentalDashboard
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "PopulationTimeline",
                url: "{controller}/{action}/{start}/{end}/{top}",
                defaults: new { controller = "DataSet", action = "CitiesPopulationTimeline", start = UrlParameter.Optional, end = UrlParameter.Optional, top = UrlParameter.Optional, }
            );
        }
    }
}
