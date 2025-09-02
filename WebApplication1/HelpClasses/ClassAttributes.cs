using System.ComponentModel.DataAnnotations;

namespace TestWebProject.HelpClasses
{
    //Пример создания атрибута для проверки длины номера карты
    public class CardLenghtAttribute : ValidationAttribute
    {
        private const int LenghtCard = 19;

        public CardLenghtAttribute(int lenght) { }

        public override bool IsValid(object? value)
        {
            var lenghtValue = value?.ToString()?.Length;
            if (value != null && LenghtCard == lenghtValue)
                return true;

            return false;
        }
    }
}
