using Microsoft.AspNetCore.Mvc;
using TestWebProject.HelpClasses;

namespace TestWebProject.Controllers
{
    public class OutputController : Controller
    {
        public IActionResult Home()
        {
            return View();
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

        //Для заполнения данных пользователя в бд. НУЖНО переделывать под себя. В данном случае это как шаблон
        [HttpPost]
        public IActionResult CreateUser(CreateUsersViewModel model)
        {
            if (!ModelState.IsValid)
            {

                // Устанавливаем флаг, что пользователь был добавлен
                ViewBag.UserAdded = true;

                // Можно также установить сообщение для TempData
                TempData["SuccessMessage"] = "Пользователь успешно создан!";

                // Очищаем модель для формы
                ModelState.Clear();

                // Возвращаем представление с пустой моделью
                return View(new CreateUsersViewModel());
            }

            // Если модель невалидна, возвращаем её с ошибками
            return View(model);
        }
    }
}
