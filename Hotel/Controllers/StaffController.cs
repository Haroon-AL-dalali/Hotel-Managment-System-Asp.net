using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult StaffList()
        {
            return View();
        }
        public IActionResult EditStaff()
        {
            return View();
        }
        public IActionResult AddStaff()
        {
            return View();
        }
    }
}
