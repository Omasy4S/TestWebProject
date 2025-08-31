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
            //����� ������ ��������
            int testValue = 16;
            return View(testValue);
        }
        public IActionResult PrintValueCollection()
        {
            //����� ���������� ��������
            var users = new List<User>
            {
                new User {Name = "������", Age = 23},
                new User {Name = "����", Age = 25},
                new User {Name = "���������", Age = 15},
                new User {Name = "��������", Age = 21},
                new User {Name = "�����", Age = 30},
                new User {Name = "���������", Age = 18},
            };
            return View(users);
        }

        //��������� ��������
        [HttpGet]
        public IActionResult Calculation() => View();

        //���������� ����� ��������� ��������
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
            //������ �� ������, �� �������� �������� ��� ���������� �������, �� ���� ������ � ��
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
