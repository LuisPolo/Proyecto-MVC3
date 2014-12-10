using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeTofood.Models
{
    public class RestaurantReview
    {
        public string Name { get; set; }

        public int Rating { get; set; }

        public string Body { get; set; }

        public DateTime Created { get; set; }

        public int Id { get; set; }

        public Restaurant Restaurant { get; set; }

        

    }
}