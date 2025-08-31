using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult PrintValue()
        {
            //вывод одного значения
            int testValue = 16;
            return View(testValue);
        }
        public IActionResult PrintValueCollection()
        {
            //вывод нескольких значений
            var users = new List<User>
            {
                new User {Name = "Максим", Age = 23},
                new User {Name = "Олег", Age = 25},
                new User {Name = "Александр", Age = 15},
                new User {Name = "Вячеслав", Age = 21},
                new User {Name = "Ирина", Age = 30},
                new User {Name = "Екатерина", Age = 18},
            };
            return View(users);
        }

        //получение значений
        [HttpGet]
        public IActionResult Calculation() => View();

        //выполнение после получения значений
        [HttpPost]
        public IActionResult Calculation(CalculateTwoNumbers model)
        {
            if (ModelState.IsValid)
            {
                model.Result = model.FirstValue + model.SecondValue;
            }
            return View(model);
        }

        [HttpGet] 
        public IActionResult CreateUser() => View();

        [HttpPost]
        public IActionResult CreateUser(CreateUsersViewModel model)
        {
            //ничего не делает, но получает значения для дальнейших дествий, по типу запись в бд
            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Output()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PrintInfo()
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
