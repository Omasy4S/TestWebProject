using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestWebProject.Models;

namespace TestWebProject.Controllers
{
    public class HomeController : Controller
    {
        //Определение поля _logger для логгирования
        private readonly ILogger<HomeController>? _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            // Вывод необходимых сообщений в лог
            _logger.LogInformation("Сообщение которое необходимо вывести");
            try
            {
                throw new ArgumentNullException();
            }
            catch (Exception ex)
            {
                //Пример вывода необходимого уровня ошибки
                _logger.LogError(ex,$"Возникла ошибка: {ex.Message}");
            }
            

            return View();
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
