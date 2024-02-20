using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            string title=saat < 12 ? "Günaydın" : "İyi Günler";
            ViewBag.header = title;
            ViewBag.User = "Süphan";
            return View();
        }
    }
}
