using System.Diagnostics;
using FavouriteThings.Models;
using Microsoft.AspNetCore.Mvc;

namespace FavouriteThings.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
