using Microsoft.AspNetCore.Mvc;

namespace _001_SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DownloadFile()
        {
            byte[] fileContent = System.IO.File.ReadAllBytes("App_Data/MVC.Middleware_8.0.zip");
            return File(fileContent, "application/zip", "Lesson.zip");
        }
    }
}
