using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerList()
        {
            return View();
        }
        public IActionResult AddCustomer()
        {
            return View();
        }  
        public IActionResult EditCustomer()
        {
            return View();
        }
    }
}
