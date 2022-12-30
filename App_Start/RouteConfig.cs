using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TravelAgencyP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "HomePage",
              url: "",
              defaults: new { controller = "HomeTravel", action = "HomePage", id = UrlParameter.Optional }
          );

            
            routes.MapRoute(
              name: "AboutUsPage",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "HomeTravel", action = "AboutUS", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "FindFlightPage",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "HomeTravel", action = "FindFlight", id = UrlParameter.Optional }
           );

            routes.MapRoute(
           name: "LoginAdminPage",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "HomeTravel", action = "LoginAdmin", id = UrlParameter.Optional }
           );

            routes.MapRoute(
          name: "LoginAcc",
          url: "{controller}/{action}/{id}",
          defaults: new { controller = "HomeTravel", action = "Verify", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "AdminHomeP",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Flights", action = "AdminHP", id = UrlParameter.Optional }
           );


            routes.MapRoute(
               name: "AddFlights",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Flights", action = "AddFlights", id = UrlParameter.Optional }
           );


            routes.MapRoute(
               name: "EditFlight",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Flights", action = "Edit", id = UrlParameter.Optional }
           );


            routes.MapRoute(
               name: "DeleteFlight",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Flights", action = "Delete", id = UrlParameter.Optional }
           );


            routes.MapRoute(
               name: "Details",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Flights", action = "Details", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
