using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication5.Controllers
{
    public class CasinoController : Controller
    {

        [ViewData] public int Count { get; set; }


        [HttpGet]
        public IActionResult Index()
        {
            Count = 1;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string dadta = "")
        {

            Count++;
            Console.WriteLine(String.IsNullOrEmpty(dadta));
            return View();
        }

        [HttpPost]
        public ActionResult ActionName(string data)
        {
            Console.WriteLine(data);
            return View();
        }
    }
}
