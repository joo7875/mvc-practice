using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joo_website.Models
{
    public class PetShop
    {
        // Shop
        public string category { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
        public int weeklyBest { get; set; }

        //Details
        public string productImage { get; set; }
        public string description { get; set; }
    }

    public class Cat : PetShop { }

    public class Dog : PetShop { }

    public class Customer
    {
        // Customer
        public int userId { get; set; }
        public string password { get; set; }
        public List<PetShop> basket { get; set; }
    }
}