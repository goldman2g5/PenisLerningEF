using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class CasinoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
