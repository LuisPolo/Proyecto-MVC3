using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using OdeTofood.Infraestructure;
using System.Data.Entity;
using OdeTofood.Models;

namespace OdeTofood
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        

        private static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogAttribute());

        }

        public static void RegisterRoutes(RouteCollection routes) 
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               "Cuisine", // Route name
               "cuisine/{name}",//Url with parameters - lo que espero ver en la url
               new { controller = "Cuisine", action = "Search", name = UrlParameter.Optional }
               );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}",//Url with parameters
                new { controller = "restaurant", action = "index", id = UrlParameter.Optional }
                );
        
        }

        protected void Application_Start()
        {

            //Database.SetInitializer(new 
            //    DropCreateDatabaseIfModelChanges<OdeToFoodDB>());

            Database.SetInitializer(new
                OdeToFoodDBInitializer());

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            //Global rpute collection
            //RouteConfig.RegisterRoutes(RouteTable.Routes);

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //AuthConfig.RegisterAuth();
        }              
    }

    public class OdeToFoodDBInitializer : 
        DropCreateDatabaseIfModelChanges<OdeToFoodDB>
    {

        protected override void Seed(OdeToFoodDB context)
        {

            base.Seed(context);

            context.Restaurants.Add(
                new Restaurant
                {
                    Name = "Mis Costillitas",
                    Adress = new Adress
                    {
                        City = "Lima",
                        State = "Peru"
                    }

                }
            );

            context.Restaurants.Add(
                new Restaurant
                {
                    Name = "Antica",
                    Adress = new Adress
                    {
                        City = "SAn isidro",
                        State = "Peru"
                    }

                }
            );

            context.Restaurants.Add(
                new Restaurant
                {
                    Name = "Rustica",
                    Adress = new Adress
                    {
                        City = "San Borja",
                        State = "Peru"
                    }

                }
            );

            context.SaveChanges();
        }
    }
}