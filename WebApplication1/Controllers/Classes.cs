using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Controllers
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class CreateUsersViewModel
    {
        [Required(ErrorMessage = "Введите имя")]
        [MaxLength(50, ErrorMessage = "Длина не должна превышать 50 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите возраст")]
        [Range(1,110,ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }

    }
    public class CalculateTwoNumbers
    {
        [Required(ErrorMessage = "Введите число")]
        [Range(1,1000000,ErrorMessage = "Первое число слишком большое")]
        public int FirstValue { get; set; }
        [Required(ErrorMessage = "Введите число")]
        [Range(1, 1000000, ErrorMessage = "Второе число слишком большое")]
        public int SecondValue { get; set; }
        public int Result { get; set; }
    }
}