using Microsoft.AspNetCore.Mvc;

namespace ActionResultsSamples.Controllers
{
    public class JsonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ClientInfo()
        {
            Client[] clients =
                {
                    new Client()
                    {
                        Id = 100,
                        Login = "user1",
                        Email = "user1@example.com"
                    },
                    new Client()
                    {
                        Id = 200,
                        Login = "user2",
                        Email = "user2@example.com"
                    },
                    new Client()
                    {
                        Id = 300,
                        Login = "user3",
                        Email = "user3@example.com"
                    }
                };

            // Json - Серіалізує об'єкт переданий у параметрах JSON і повертає клієнту відповідь.
            return Json(clients);
        }

        public IActionResult ClientInfo2()
        {
            // використання анонімних типів для формування JSON відповіді
            return Json(new
            {
                Id = 200,
                Login = "user2",
                Email = "user2@example.com"
            });
        }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }
}
