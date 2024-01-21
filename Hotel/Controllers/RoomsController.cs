using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult RoomList()
        {
            return View();
        }  
        public IActionResult AddRoom()
        {
            return View();
        } 
        public IActionResult EditRoom()
        {
            return View();
        }
    }
}
