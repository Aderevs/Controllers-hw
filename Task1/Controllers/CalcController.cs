using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
    public class Calc : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        // POST: Calculator/Calculate
        [HttpPost]
        public ActionResult Calculate(string firstNumber, string secondNumber, string operation)
        {
            double num1, num2;
            if (double.TryParse(firstNumber, out num1) && double.TryParse(secondNumber, out num2))
            {
                double result = 0;
                switch (operation)
                {
                    case "add":
                        result = num1 + num2;
                        break;
                    case "subtract":
                        result = num1 - num2;
                        break;
                    case "multiply":
                        result = num1 * num2;
                        break;
                    case "divide":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            ViewBag.ErrorMessage = "Division by zero is not allowed!";
                        break;
                }
                ViewBag.Result = result;
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid input. Please enter valid numbers.";
            }
            return View("Index");
        }
    }

}
