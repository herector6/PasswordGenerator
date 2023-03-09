using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace PasswordGenerator.Controllers
{
    public class HomeController : Controller
    {
        private const string _validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int length = 12)
        {
            var random = new Random();
            var password = new string(Enumerable.Repeat(_validChars, length).Select(s => s[random.Next(s.Length)]).ToArray());

            ViewBag.Password = password;
            return View();
        }
    }
}
