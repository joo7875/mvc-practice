using Joo_website.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joo_website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Welcome = hour < 12 ? "Good Morning!" : "Good Afternoon!";
            return View();
        }

        public ActionResult PetPage(string petType)
        {
            var petList = new List<PetShop>{
                            new PetShop() { category = "Dog", productId = 1, productName = "Doggy Food 6kg", price = 22, weeklyBest = 6, productImage = "d1" },
                            new PetShop() { category = "Dog", productId = 2, productName = "Chewing Gum", price = 5, weeklyBest = 2, productImage = "d2" },
                            new PetShop() { category = "Dog", productId = 3, productName = "Beef&Pork for Dog", price = 10, weeklyBest = 3, productImage = "d3" },
                            new PetShop() { category = "Dog", productId = 4, productName = "Doggy Ball", price = 3, weeklyBest = 5, productImage = "d4" },
                            new PetShop() { category = "Dog", productId = 5, productName = "Doggy Nutritional Food 3kg", price = 15, weeklyBest = 4, productImage = "d5" },
                            new PetShop() { category = "Dog", productId = 6, productName = "Chewy Bone", price = 8, weeklyBest = 1, productImage = "d6" },
                            new PetShop() { category = "Dog", productId = 7, productName = "Fruity Medicine", price = 20, weeklyBest = 7, productImage = "d7" },
                            new PetShop() { category = "Cat", productId = 1, productName = "Cat Food 6kg", price = 22, weeklyBest = 6, productImage = "c1" },
                            new PetShop() { category = "Cat", productId = 2, productName = "Chewing Gum", price = 5, weeklyBest = 2, productImage = "c2" },
                            new PetShop() { category = "Cat", productId = 3, productName = "Fish&Vege for Cat", price = 10, weeklyBest = 3, productImage = "c3" },
                            new PetShop() { category = "Cat", productId = 4, productName = "Kitten Ball", price = 3, weeklyBest = 5, productImage = "c4" },
                            new PetShop() { category = "Cat", productId = 5, productName = "Cat Nutritional Food 3kg", price = 15, weeklyBest = 4, productImage = "c5" },
                            new PetShop() { category = "Cat", productId = 6, productName = "Chewy Bone", price = 8, weeklyBest = 1, productImage = "c6" },
                            new PetShop() { category = "Cat", productId = 7, productName = "Fruity Medicine", price = 20, weeklyBest = 7, productImage = "c7" }
            };

            if (string.IsNullOrEmpty(petType))
                petType = "Dog";

            var retList = new List<PetShop>();

            //int nIdx = 1;

            foreach (PetShop item in petList)
            {
                if (item.category == petType)
                {
                    //item.productId = nIdx;
                    retList.Add(item);
                    //nIdx++;
                }
            }

            // Title Name
            ViewBag.petType = petType;

            return View(retList);
        }

        //public ActionResult CatPage()
        //{
        //    var catList = new List<Cat>
        //    {
        //                    new Cat() { category = "cat", productId = 8, productName = "Cat Food 6kg", price = 22, weeklyBest = 6 },
        //                    new Cat() { category = "cat", productId = 9, productName = "Chewing Gum", price = 5, weeklyBest = 2 },
        //                    new Cat() { category = "cat", productId = 10, productName = "Fish&Vege for Cat", price = 10, weeklyBest = 3 },
        //                    new Cat() { category = "cat", productId = 11, productName = "Kitten Ball", price = 3, weeklyBest = 5 },
        //                    new Cat() { category = "cat", productId = 12, productName = "Cat Nutritional Food 3kg", price = 15, weeklyBest = 4 },
        //                    new Cat() { category = "cat", productId = 13, productName = "Chewy Bone", price = 8, weeklyBest = 1 },
        //                    new Cat() { category = "cat", productId = 14, productName = "Fruity Medicine", price = 20, weeklyBest = 7 }
        //    };

        //    return View(catList);
        //}

        public ActionResult Details(string id)
        {
            var dir = Server.MapPath("/Content/Images");
            var path = Path.Combine(dir, id + ".jpg");
            //ViewBag.Image = base.File(path, "image/jpeg");

            ViewBag.Image = "/Content/Images/" + id + ".jpg";
            ViewBag.description = "Healthy Dogs and Cats";
            return View();

            //return base.File(path, "image/jpeg");
            //return View(base.File(path, "image/jpeg"));
        }
    }
}