using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult AddEmployee()
        {
            return View();
        }
        public IActionResult EmployeeList()
        {
            return View();
        }
        public IActionResult Holyday ()
        {
            return View();
        }
        public IActionResult Leave()
        {
            return View();
        }
    }
}
