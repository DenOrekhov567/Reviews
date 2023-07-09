using Microsoft.AspNetCore.Mvc;
using Reviews.Models;
using System.Diagnostics;

namespace Reviews.Controllers
{
    public class HomeController : Controller
    {
        // Приватное поле, хранящее объект базы данных AppDbContext
        private AppDbContext db;

        /* 
         * Конструктор класса HomeController
         * В параметрах внедрение зависимости от контекста базы данных AppDbContext
         */
        public HomeController(AppDbContext db)
        {
            // Присваивание переданного экземпляра базы данных приватному полю db
            this.db = db;
        }

        // Метод, который будет вызываться при обращении к маршруту по умолчанию
        public IActionResult Index()
        {
            // Возвращает представление Index, передавая список отзывов из базы данных в представление 
            return View(db.Reviews.ToList());
        }

        // Метод, который будет вызываться при возникновении ошибки
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Возвращает представление Error с информацией об ошибке, если таковая произошла
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}