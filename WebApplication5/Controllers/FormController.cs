using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
