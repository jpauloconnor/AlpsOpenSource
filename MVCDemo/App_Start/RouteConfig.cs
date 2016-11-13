using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDemo
{
    public class RouteConfig
    {

        //Bronze Challenge: Change the MapRoute so that the pages default to the about page in Home. 

        /// <summary>
        /// A MUST READ:
        /// https://www.asp.net/mvc/overview/older-versions-1/controllers-and-routing/asp-net-mvc-routing-overview-cs
        /// This file fires up at App Start time and dictates how the requests go.
        /// When an MVC application first starts, the Application_Start() method is called. This method, in turn, calls the RegisterRoutes() method. The RegisterRoutes() method creates the route table.
        /// The default route table contains a single route(named Default). The Default route maps the first segment of a URL to a controller name, the second segment of a URL to a controller action, and the third segment to a parameter named id.
        /// Imagine that you enter the following URL into your web browser's address bar:
        /// /Home/Index/3
        /// The Default route maps this URL to the following parameters:
        /// controller = Home
        /// action = Index
        /// id = 3
        /// When you req that URL /Home/Index/3
        /// HomeController.Index(3) is executed
        /// 
        /// </summary>
        /// 

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //Allows you to customize your URLs and set default URLs.
            //If I run the app right now, it will go like this -

            //HomeController -> Index Method
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                                //Bronze: Change action to "About"
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}
