using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestWebProject.Models;

namespace TestWebProject.Controllers
{
    public class HomeController : Controller
    {
        //����������� ���� _logger ��� ������������
        private readonly ILogger<HomeController>? _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            // ����� ����������� ��������� � ���
            _logger.LogInformation("��������� ������� ���������� �������");
            try
            {
                throw new ArgumentNullException();
            }
            catch (Exception ex)
            {
                //������ ������ ������������ ������ ������
                _logger.LogError(ex,$"�������� ������: {ex.Message}");
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
