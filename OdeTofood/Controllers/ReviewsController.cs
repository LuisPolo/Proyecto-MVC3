using OdeTofood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeTofood.Controllers
{
    public class ReviewsController : Controller
    {

        OdeToFoodDB _db = new OdeToFoodDB();

        //
        // GET: /Reviews/

        public ActionResult Index()
        {

            var model = _db.Reviews;

           
            return View(model);
        }

        [ChildActionOnly] //Solo que sea llamado por el hijo. asi sepa la ruta no lo va a llamar
        public ActionResult BestReview()
        {
            ////Se comenta ya que no tiene Reviews en List, en duro
            //var model = _db.Reviews.Find(x => x.Id == 1);

            var model = _db.Reviews.Find(1);

            return PartialView("_Review" ,model);
        }

        //
        // GET: /Reviews/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reviews/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reviews/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Reviews/Edit/5

        public ActionResult Edit(int id)
        {
            ////Se comenta ya que no tiene Reviews en List, en duro
            //var Review = _db.Reviews.Find(x => x.Id == id);

            //Ahora es DbSet
            var Review = _db.Reviews.Find(id);

            return View(Review);
        }

        //
        // POST: /Reviews/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
             // TODO: Add update logic here
            ////Se comenta ya que no tiene Reviews en List, en duro
            //var Review = _db.Reviews.Find(x => x.Id == id);

                var Review = _db.Reviews.Find(id);

                //Look for values in the request that can be moved to
                //a particular model object. If Review has a body
                //is gonna look out sowhere. Trata de llenar el modelo 
                //con valores del request

               if(TryUpdateModel(Review))
                    return RedirectToAction("Index");

               return View(Review);
           
        }

        //
        // GET: /Reviews/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reviews/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
