using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using static WebApplication5.Models.FormModel;

namespace WebApplication5.Models
{
    [BindProperties]
    public class FormModel : PageModel
    {
        public FormModel()
        {
            Name = "";
            Surname = "";
        }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}