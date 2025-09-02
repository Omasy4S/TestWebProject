using System.ComponentModel.DataAnnotations;

namespace TestWebProject.HelpClasses
{
    public class User
    {
        public string? Name { get; init; }
        public int Age { get; init; }
    }
    public class CreateUsersViewModel
    {
        [Required(ErrorMessage = "Введите имя")]
        [MaxLength(50, ErrorMessage = "Длина не должна превышать 50 символов")]
        public string? Name { get; init; }

        [Required(ErrorMessage = "Введите возраст")]
        [Range(1,110,ErrorMessage = "Недопустимый возраст")]
        public int Age { get; init; }
        [CardLenght(19,ErrorMessage = "Некорректный номер карты")]
        public int CardNumber { get; init; }

    }
    public class CalculateTwoNumbers
    {
        [Required(ErrorMessage = "Введите число")]
        [Range(1,1000000,ErrorMessage = "Первое число слишком большое")]
        public int FirstValue { get; init; }
        [Required(ErrorMessage = "Введите число")]
        [Range(1, 1000000, ErrorMessage = "Второе число слишком большое")]
        public int SecondValue { get; init; }
        public int Result { get; set; }
    }
}