using Microsoft.AspNetCore.Mvc;

namespace AllApp.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
