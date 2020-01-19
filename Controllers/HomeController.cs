using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Al_Web_Store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Product_Details()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogSingle()
        {
            return View();
        }

        public IActionResult NotFound_404()
        {
            return View();
        }

        public IActionResult Contact_Us()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}