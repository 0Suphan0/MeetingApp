using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            MeetingInfo meetingInfo = new MeetingInfo() {
                Id = 1,
                Location = "Ankara Sincan Mustafa Kemal Salonu",
                NumberOfPeople = 100,
                Time = new DateTime(2024, 01, 20, 20, 0, 0)
            };


            int saat = DateTime.Now.Hour;
            string title=saat < 12 ? "Günaydın" : "İyi Günler";
            ViewBag.header = title;
            ViewBag.User = "Süphan";
            return View(meetingInfo);
        }
    }
}
