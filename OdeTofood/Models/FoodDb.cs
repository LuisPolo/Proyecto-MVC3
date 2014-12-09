using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeTofood.Models
{
    public class FoodDb
    {

        public List<RestaurantReview> Reviews
        {
            get
            {
                return _reviews;
            }
            set
            {
                _reviews = value;
            }
        }

        static List<RestaurantReview> _reviews;

        static FoodDb()
        {
            _reviews = new List<RestaurantReview>();

            _reviews.Add(new RestaurantReview
                {
                    Body = "Only eat here if you must",
                    Created = DateTime.Now,
                    Id = 1,
                    Rating = 9,
                    Restaurant = new Restaurant
                    {
                        Name = "Mannequin Pis"
                    }
                });

            _reviews.Add(new RestaurantReview
            {
                Body = "Las mejores costillas de la region",
                Created = DateTime.Now,
                Id = 2,
                Rating = 2,
                Restaurant = new Restaurant
                {
                    Name = "Mis costillitas"
                }
            });

            _reviews.Add(new RestaurantReview
            {
                Body = "Pastas masomenos",
                Created = DateTime.Now,
                Id = 1,
                Rating = 15,
                Restaurant = new Restaurant
                {
                    Name = "Pasion Italiana"
                }
            });
        
        }

    }
}