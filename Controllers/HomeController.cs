using System;
using System.Collections.Generic;
using System.Web.Mvc;
using T1_Luisa.Models; // Ensure this namespace matches your project structure

namespace T1_Luisa.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products
        public ActionResult Products()
        {
            var fruits = new List<Fruit>
            {
                new Fruit { Id = 1, Name = "Apple", Description = "Fresh and crisp apples from local orchards.", Price = 1.99m, ImageUrl = "/Content/images/Manzana.jpg" },
                new Fruit { Id = 2, Name = "Banana", Description = "Sweet and nutritious bananas.", Price = 0.99m, ImageUrl = "/Content/images/Banana.jpg" },
                new Fruit { Id = 3, Name = "Orange", Description = "Juicy oranges packed with vitamin C.", Price = 1.49m, ImageUrl = "/Content/images/Orange.jpg" },
                new Fruit { Id = 4, Name = "Strawberry", Description = "Sweet and delicious strawberries.", Price = 2.99m, ImageUrl = "/Content/images/Fresa.jpg" },
                new Fruit { Id = 5, Name = "Mango", Description = "Tropical mangoes with rich flavor.", Price = 2.49m, ImageUrl = "/Content/images/Mango.jpg" }
            };

            return View(fruits);
        }

        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }
    }
}