using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace OdeTofood.Models
{
    //Esta es la base de datos que quiero crear
    public class OdeToFoodDB : DbContext
    {
        //Entity framework generara un esquema para Restaurant y Review
        public DbSet<Restaurant> Restaurants { get; set; }

        //mejor es usar siempre interfaces
        public DbSet<Review> Reviews { get; set; }

       

        /*SIN CONEXION DE BASE DE DATOS*/
        //public List<Review> Reviews
        //{
        //    get
        //    {
        //        return _Reviews;
        //    }
        //    set
        //    {
        //        _Reviews = value;
        //    }
        //}

        //static List<Review> _Reviews;



        //static OdeToFoodDB()
        //{
        //    _Reviews = new List<Review>();

        //    var ruta = HttpContext.Current.Server.MapPath(".");

        //    _Reviews.Add(new Review
        //        {
        //            Body = "Only eat here if you must",
        //            Created = DateTime.Now,
        //            Id = 1,
        //            Rating = 9,
        //            Restaurant = new Restaurant
        //            {
        //                Name = "Mannequin Pis"  ,
        //                ImageUrl = "http://localhost:27788/Images/luffyeating.jpg"
        //            }
        //        });



        //    _Reviews.Add(new Review
        //    {
        //        Body = "Las mejores costillas de la region",
        //        Created = DateTime.Now,
        //        Id = 2,
        //        Rating = 2,
        //        Restaurant = new Restaurant
        //        {
        //            Name = "Mis costillitas",
        //           ImageUrl = "http://localhost:27788/Images/luffyeating.jpg"

        //        }
        //    });

        //    _Reviews.Add(new Review
        //    {
        //        Body = "Pastas masomenos",
        //        Created = DateTime.Now,
        //        Id = 1,
        //        Rating = 15,
        //        Restaurant = new Restaurant
        //        {
        //            Name = "Pasion Italiana",
        //            ImageUrl = "http://localhost:27788/Images/luffyeating.jpg"

        //        }
        //    });

        //}

    }
}