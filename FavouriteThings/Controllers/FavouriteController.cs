using Microsoft.AspNetCore.Mvc;

namespace FavouriteThings.Controllers
{
    public class FavouriteController : Controller
    {
        public IActionResult Games()
        {
            return View();
        }
        public IActionResult Music()
        {
            return View();
        }
        public IActionResult Movies()
        {
            return View();
        }
    }
}
