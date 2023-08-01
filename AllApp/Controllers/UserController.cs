using AllApp.Data;
using AllApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AllApp.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;                
        }

        public IActionResult Index()
        {
            List<User> objUserList = _db.Users.ToList();
            return View(objUserList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User obj)
        {
            _db.Users.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index","User");
        }
    }
}
