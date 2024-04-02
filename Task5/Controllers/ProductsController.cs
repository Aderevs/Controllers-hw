using Microsoft.AspNetCore.Mvc;
using Task5.Models;

namespace Task5.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult IndexViewData()
        {
            List<Item> items = new()
            {
                new Item(1, 10.99, "Item 1"),
                new Item(2, 5.49, "Item 2"),
                new Item(3, 7.25, "Item 3"),
                new Item(4, 12.75, "Item 4"),
                new Item(5, 9.99, "Item 5")
            };
            ViewData["count"] = items.Count;
            ViewData["items' ids"] = items.Select(x => x.Id).ToList();
            ViewData["items' prices"] = items.Select(x => x.Price).ToList();
            ViewData["items' names"] = items.Select(x => x.Name).ToList();
            return View();
        }
        public IActionResult IndexViewBag()
        {
            List<Item> items = new()
            {
                new Item(1, 10.99, "Item 1"),
                new Item(2, 5.49, "Item 2"),
                new Item(3, 7.25, "Item 3"),
                new Item(4, 12.75, "Item 4"),
                new Item(5, 9.99, "Item 5")
            };
            ViewBag.Count = items.Count;
            ViewBag.ItemsIds = items.Select(x => x.Id).ToList();
            ViewBag.ItemsPrices = items.Select(x => x.Price).ToList();
            ViewBag.ItemsNames = items.Select(x => x.Name).ToList();
            return View();
        }
    }
}
