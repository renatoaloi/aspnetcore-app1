using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp1.Pages
{
    public class IndexModel : PageModel
    {
        public static string Message { get; set; }
        public string Test { get; set; }

        public void OnGet()
        {
            Message = "Messagem from Model!";
        }
    }
}