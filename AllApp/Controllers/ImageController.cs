using AllApp.Data;
using AllApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AllApp.Controllers
{
    public class ImageController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ImageController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Image> objImageList = _db.Images.ToList();
            return View();
        }
    }
}
