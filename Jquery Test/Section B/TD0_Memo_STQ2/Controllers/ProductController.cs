using STQ2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STQ2.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product("Milk", 20),
                new Product("Bread", 13),
                new Product("Cola", 8),
                new Product("Chocolate", 10),
            };

            return View(products);
        }
    }
}