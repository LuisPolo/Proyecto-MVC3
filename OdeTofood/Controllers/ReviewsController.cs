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

        FoodDb _db = new FoodDb();

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

            var model = _db.Reviews.Find(x=>x.Id==1);

            
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
            
            var review = _db.Reviews.Find(x => x.Id == id);

            return View(review);
        }

        //
        // POST: /Reviews/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
             // TODO: Add update logic here

                var review = _db.Reviews.Find(x => x.Id == id);

                //Look for values in the request that can be moved to
                //a particular model object. If review has a body
                //is gonna look out sowhere. Trata de llenar el modelo 
                //con valores del request

               if(TryUpdateModel(review))
                    return RedirectToAction("Index");

               return View(review);
           
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
