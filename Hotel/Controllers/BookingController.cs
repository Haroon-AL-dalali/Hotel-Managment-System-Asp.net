using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult bookingList()
        {
            return View();
        }  
        public IActionResult EditBooking()
        {
            return View();
        }  
        public IActionResult AddBooking()
        {
            return View();
        }
    }
}
