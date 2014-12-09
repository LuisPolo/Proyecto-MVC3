using OdeTofood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeTofood.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

           ViewBag.Message = string.Format("{0}::{1}{2}",                
                RouteData.Values["controller"],                
                RouteData.Values["action"],
                RouteData.Values["id"]);

            var model = new RestaurantReview();
            model.Name = "Long Horn";
            model.Rating = 9;

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descripcion de la pagina";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
