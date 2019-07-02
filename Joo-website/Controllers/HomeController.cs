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

        public ActionResult DogPage()
        {
            var dogList = new List<Dog>{
                            new Dog() { category = "dog", productId = 1, productName = "Doggy Food 6kg", price = 22, weeklyBest = 6 },
                            new Dog() { category = "dog", productId = 2, productName = "Chewing Gum", price = 5, weeklyBest = 2 },
                            new Dog() { category = "dog", productId = 3, productName = "Beef&Pork for Dog", price = 10, weeklyBest = 3 },
                            new Dog() { category = "dog", productId = 4, productName = "Doggy Ball", price = 3, weeklyBest = 5 },
                            new Dog() { category = "dog", productId = 5, productName = "Doggy Nutritional Food 3kg", price = 15, weeklyBest = 4 },
                            new Dog() { category = "dog", productId = 6, productName = "Chewy Bone", price = 8, weeklyBest = 1 },
                            new Dog() { category = "dog", productId = 7, productName = "Fruity Medicine", price = 20, weeklyBest = 7 }
            };

            return View(dogList);
        }

        public ActionResult CatPage()
        {
            var catList = new List<Cat>
            {
                            new Cat() { category = "cat", productId = 8, productName = "Cat Food 6kg", price = 22, weeklyBest = 6 },
                            new Cat() { category = "cat", productId = 9, productName = "Chewing Gum", price = 5, weeklyBest = 2 },
                            new Cat() { category = "cat", productId = 10, productName = "Fish&Vege for Cat", price = 10, weeklyBest = 3 },
                            new Cat() { category = "cat", productId = 11, productName = "Kitten Ball", price = 3, weeklyBest = 5 },
                            new Cat() { category = "cat", productId = 12, productName = "Cat Nutritional Food 3kg", price = 15, weeklyBest = 4 },
                            new Cat() { category = "cat", productId = 13, productName = "Chewy Bone", price = 8, weeklyBest = 1 },
                            new Cat() { category = "cat", productId = 14, productName = "Fruity Medicine", price = 20, weeklyBest = 7 }
            };

            return View(catList);
        }

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