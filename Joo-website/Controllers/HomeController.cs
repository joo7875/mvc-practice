﻿using Joo_website.Models;
using System;
using System.Collections.Generic;
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
                            new Dog() { category = "dog", productId = 1, productName = "Doggy Food 6kg", weeklyBest = 6 },
                            new Dog() { category = "dog", productId = 2, productName = "Chewing Gum", weeklyBest = 2 },
                            new Dog() { category = "dog", productId = 3, productName = "Beef&Pork for Dog", weeklyBest = 3 },
                            new Dog() { category = "dog", productId = 4, productName = "Doggy Ball", weeklyBest = 5 },
                            new Dog() { category = "dog", productId = 5, productName = "Doggy Nutritional Food 3kg", weeklyBest = 4 },
                            new Dog() { category = "dog", productId = 6, productName = "Chewy Bone", weeklyBest = 1 },
                            new Dog() { category = "dog", productId = 7, productName = "Fruity Medicine", weeklyBest = 7 }
            };

            return View(dogList);
        }

        public ActionResult CatPage()
        {
            var catList = new List<Cat>
            {
                            new Cat() { category = "cat", productId = 1, productName = "Cat Food 6kg", weeklyBest = 6 },
                            new Cat() { category = "cat", productId = 2, productName = "Chewing Gum", weeklyBest = 2 },
                            new Cat() { category = "cat", productId = 3, productName = "Fish&Vege for Cat", weeklyBest = 3 },
                            new Cat() { category = "cat", productId = 4, productName = "Kitten Ball", weeklyBest = 5 },
                            new Cat() { category = "cat", productId = 5, productName = "Cat Nutritional Food 3kg", weeklyBest = 4 },
                            new Cat() { category = "cat", productId = 6, productName = "Chewy Bone", weeklyBest = 1 },
                            new Cat() { category = "cat", productId = 7, productName = "Fruity Medicine", weeklyBest = 7 }
            };

            return View(catList);
        }
    }
}