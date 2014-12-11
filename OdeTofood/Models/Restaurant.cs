using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeTofood.Models
{
   public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public Adress Adress { get; set; }
        public string ChefsName { get; set; }        
        //public string City { get; set; }
        //public string State { get; set; }
        //public string Country { get; set; }
        public string ImageUrl { get; set; }

      
    }
}
