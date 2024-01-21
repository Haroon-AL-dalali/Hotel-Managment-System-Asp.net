using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class PayrollController : Controller
    {
        public IActionResult EmployeeSalary()
        {
            return View();
        } 
        public IActionResult Payslip()
        {
            return View();
        }  
        public IActionResult AddSalary()
        {
            return View();
        }
    }
}
