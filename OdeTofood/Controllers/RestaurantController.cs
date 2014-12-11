using OdeTofood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeTofood.Controllers
{
    public class RestaurantController : Controller
    {
        //
        // GET: /Restaurant/

        OdeToFoodDB _db = new OdeToFoodDB();

        public ActionResult Index(string city)
        {
            //Formas de pasar informacion del controller al view
            //Viewbag

            ViewBag.States = _db.Restaurants.Select(r => r.Adress.City);


            //Strngly tyoe model approach
            //parameter with and extention method
            var model = _db.Restaurants
                        .OrderByDescending(r => r.Adress.City)
                        .Where(r => r.Adress.City == city || (city == null));
                                    
            //comprenhension query sintaxt
            //var model = from r in _db.Restaurants
            //            orderby r.Adress.City descending
            //            where r.Adress.City == city || (city == null)
            //            select r;

            //Siempre pasar el model
            return View(model);
        }

        //
        // GET: /Restaurant/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Restaurant/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Restaurant/Create

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
        // GET: /Restaurant/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Restaurant/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Restaurant/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Restaurant/Delete/5

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
