using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeTofood.Infraestructure;

namespace OdeTofood.Controllers
{
    //[Authorize]
    //[Log] //No es necesario poner la palabra attribute. Ya no se coloca porque esta en el global.asax
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        // Va a buscar el valor de name en el query string sin importar si sigue la
        //estructura controller/name
        [HttpGet]      
        //[Authorize] // Puede estar a nivel de la accion o del controlador
        public ActionResult Search(string name = "*") 
        {

            var ruta = Server.MapPath("~/Content/Site.css");

            throw new Exception("oops i fucked!");

          /*  if (name == "*")
            {
                //puedo redireccionar a una accion determinada en un controlador determinado
                    //return RedirectToAction("Search", "Cuisine", new { name = "french" });

                //se puede redireccionar a una ruta determinada
                    //return RedirectToRoute("cuisine", new { name = "german" });
            
                //puedo redireccionar inclusive archivos
                    //return File(Server.MapPath("~/Content/Site.css"), "text/css");

                //puedo retornar un resultadi de tipo json. Jvscript serialize in json 
                return Json(new { cuisineName = name }, JsonRequestBehavior.AllowGet);
            }*/
                     

             name = Server.HtmlEncode(name);
            
            // return RedirectToAction("Index", "Home"); // Redirecciona a la accion index del controlador Home

            
            return Content(name);
        }

    }
}
