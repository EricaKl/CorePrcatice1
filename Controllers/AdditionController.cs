using CorePrcatice1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorePrcatice1.Controllers
{
    public class AdditionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Number number = new Number();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Number number)
        {
            ViewBag.Result = number.number1 + number.number2;
            
            return View();
        }
    }
}
