using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Text;
using Task2.Models;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {

            var headers = Request.Headers
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.FirstOrDefault());

            var clientBrowser = headers["sec-ch-ua"].Split(';')[0];
            var clientHost = Request.Host;
            var ipAddress = HttpContext.Connection.RemoteIpAddress.ToString();
            return $"IP: {ipAddress}; \nbrowser: {clientBrowser}";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
