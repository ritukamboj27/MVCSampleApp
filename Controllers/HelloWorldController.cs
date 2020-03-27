using Microsoft.AspNetCore.Mvc;

namespace MVCSampleapp.Controllers
{
    public class HelloWorldController:Controller
    {
        public IActionResult Index()
        {
            ViewData["HelloWorld"] = "Hello, This is my view";
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Welcome"] = "Hello, Welcome to HelloWorld Application";
            return View();
        }
    }
}