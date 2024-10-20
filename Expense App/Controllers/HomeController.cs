using Expense_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Expense_App.Controllers
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

        public IActionResult CreateEditExpense()
        {
            return View();
        }

        public IActionResult CreateEditExpenseForm()
        {
            return RedirectToAction("Index");
        }
            

        //Controller za otvaranje Stranice
        public IActionResult Expenses()
        {
            return View(); //Return View() znaci da ce otvoriti view sa istim imenom kao metoda
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
