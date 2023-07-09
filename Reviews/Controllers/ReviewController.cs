using Microsoft.AspNetCore.Mvc;
using Reviews.Models;

namespace Reviews.Controllers
{
    public class ReviewController : Controller
    {
        // Приватное поле, хранящее объект базы данных AppDbContext
        private AppDbContext db;

        /* 
         * Конструктор класса ReviewController
         * В параметрах внедрение зависимости от контекста базы данных AppDbContext
         */
        public ReviewController(AppDbContext db)
        {
            // Присваиваем переданный экземпляр базы данных приватному полю db
            this.db = db;
        }

        // Метод, который будет вызываться при обращении к маршруту Index
        public ActionResult Index()
        {
            // Возвращаем представление Index
            return View();
        }

        // Метод, который будет вызываться при отправке формы с добавлением нового отзыва
        public ActionResult Add(ReviewModel model)
        {
            // Добавим новую запись в базу данных с использованием модели отзыва
            db.Add(model);
            // Сохраненим изменения в базе данных
            db.SaveChanges();

            // Перенаправлим на главную страницу Index контроллера Home
            return RedirectToAction("Index", "Home");
        }
    }
}
