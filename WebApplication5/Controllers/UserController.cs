using Microsoft.AspNetCore.Mvc;
using WebApplication5.Data;
using WebApplication5.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Controllers
{
    public class UserController : Controller
    {
        private readonly TimurContext _context;

        public UserController(TimurContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<User> users = _context.Users.ToList();
            return View(users);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            User user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            _context.Attach(user);
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            User user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            return View(user);
        }

        [HttpPost]
        public IActionResult Delete(User user)
        {
            _context.Attach(user);
            _context.Entry(user).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _context.Attach(user);
            _context.Entry(user).State = EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        

    }
}
