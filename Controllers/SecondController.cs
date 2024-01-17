using CorePrcatice1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorePrcatice1.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index1()
        {
            //Employee emp = new Employee();
            List<Employee> emp = new List<Employee>()
               {
                   new Employee() { Id = 1 , Name = "Erica" , Department = "IT Software" , Designation = "Software Engineer"},
                   new Employee() { Id = 2 , Name = "Anshit" , Department = "IT HelpDesk" , Designation = "Assistant"},
                   new Employee() { Id = 3 , Name = "Mahi" , Department = "IT Software" , Designation = "Software Engineer"},
                   new Employee() { Id = 4 , Name = "Pia" , Department = "Marketing" , Designation = "Sales Re"},
                   new Employee() { Id = 5 , Name = "Bhumika" , Department = "Marketing" , Designation = "Sales Re"}
               };

            ViewBag.Employees = emp;
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            return View();
        }
    }
}
