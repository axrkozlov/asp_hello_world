using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RazorPagesMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public String Index()
        {
            return "This is my default action...";
            //return View();
        }
        public String Welcome(String name, int ID = 5)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, numtimes is: {ID}");
        }
    }
}
