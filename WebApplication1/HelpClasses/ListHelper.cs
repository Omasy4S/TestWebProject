using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TestWebProject.HelpClasses
{
    public static class ListHelper
    {
        // Хелпер для создания параграфа
        public static HtmlString CreateParagraph(this IHtmlHelper html, string text)
        {
            // Просто возвращаем HTML-строку с тегом <p>
            return new HtmlString($"<p>{text}</p>");
        }

        // Хелпер для создания выпадающего списка
        public static HtmlString CreateList(this IHtmlHelper html, IEnumerable<Product> products)
        {
            // Начинаем формировать выпадающий список
            string result = "<select class='custom-select'>";
            result += "<option selected disabled>Выберите продукт</option>";

            // Добавляем варианты для каждого продукта
            foreach (var product in products)
            {
                result += $"<option>{product.ProductName}</option>";
            }

            // Завершаем список
            result += "</select>";

            return new HtmlString(result);
        }

        // Хелпер для генерации заголовка страницы
        public static HtmlString RenderPageHead(this IHtmlHelper html, string title)
        {
            // Формируем всю HTML-разметку для head
            string headContent = @"
        <meta charset='UTF-8'>
        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
        <title>" + title + @"</title>
        <link href='https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css' rel='stylesheet'>
        <style>
            body { background-color: #f8f9fa; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; }
            .custom-container { max-width: 800px; margin: 2rem auto; padding: 2rem; background: white; border-radius: 12px; box-shadow: 0 4px 12px rgba(0,0,0,0.1); }
            .custom-header { color: #3a7bd5; border-bottom: 2px solid #3a7bd5; padding-bottom: 0.5rem; margin-bottom: 1.5rem; }
            .custom-select { padding: 0.75rem; border-radius: 8px; border: 1px solid #ced4da; background-color: #f8f9fa; transition: all 0.3s; width: 100%; }
            .custom-select:focus { border-color: #3a7bd5; box-shadow: 0 0 0 0.2rem rgba(58, 123, 213, 0.25); }
            .product-card { background: linear-gradient(135deg, #f5f7fa 0%, #c3cfe2 100%); border-radius: 8px; padding: 1.5rem; margin-top: 1.5rem; }
        </style>";

            return new HtmlString(headContent);
        }
    }
}