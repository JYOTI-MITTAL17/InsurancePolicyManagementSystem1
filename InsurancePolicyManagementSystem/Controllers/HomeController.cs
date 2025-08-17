using InsurancePolicyManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InsurancePolicyManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(int Number1, int Number2, string Operation)
        {
            int result = 0;

            switch (Operation)
            {
                case "+":
                    result = Number1 + Number2;
                    break;
                case "-":
                    result = Number1 - Number2;
                    break;
                case "*":
                    result = Number1 * Number2;
                    break;
                case "%":
                    result = Number1 % Number2;
                    break;
                default:
                    ViewBag.Error = "Invalid operation.";
                    return View("Index");
            }

            ViewBag.Result = result;
            return View("Index");
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
//        Does**
//- Adds a `Calculate` method that handles `POST` requests from the form.
//- Performs basic arithmetic based on the selected operation.
//- Returns the result to the same `Index` view using `ViewBag`.

//---

//Would you like help creating a model or view model to make this more structured, or adding validation and error handling for edge cases like division by zero?