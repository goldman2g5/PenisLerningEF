using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using static WebApplication5.Models.FormModel;

namespace WebApplication5.Models
{
    public class FormModel : PageModel
    {

        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Surname { get; set; }
        [BindProperty] public string Age { get; set; }
        [BindProperty]
        public string City { get; set; }

        public void OnPost()
        {
            ViewData["sentence"] = $"{Name} {Surname}, {Age} lives in {City}.";
        }

        public void OnGet()
        {
            ViewData["sentence"] = "";
        }
    }
}