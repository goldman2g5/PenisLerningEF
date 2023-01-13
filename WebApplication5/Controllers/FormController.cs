using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class FormController : Controller
    {
        [ViewData] public string Sentence { get; set; }


        [HttpGet]
        public IActionResult Index()
        {
            Sentence = "Bebra";
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string surname)
        {
            Sentence = $"{name} {surname} is daun";
            return View();
        }

    }
}
