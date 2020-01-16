using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeTask_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeTask_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<StudentView> _student = new List<StudentView>
        {
            new StudentView
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Age = 22,
                Telefon = "89994445678",
                Course = 3
            },

            new StudentView
            {
                Id = 2,
                FirstName = "Алексей",
                SurName = "Гикбрейнс",
                Age = 20,
                Telefon = "89132348563",
                Course = 2
            },

            new StudentView
            {
                Id = 3,
                FirstName = "Сергей",
                SurName = "Медведев",
                Age = 21,
                Telefon = "911",
                Course = 3
            },

            new StudentView
            {
                Id = 4,
                FirstName = "Глеб",
                SurName = "Хлебников",
                Age = 23,
                Telefon = "89024563218",
                Course = 5
            },

            new StudentView
            {
                Id = 5,
                FirstName = "Владимир",
                SurName = "Петухов",
                Age = 25,
                Telefon = "89698741526",
                Course = 6
            },
        };

        public IActionResult Index()
        {
            return View(_student);
        }

        public IActionResult Details(int id)
        {
            var student = _student.FirstOrDefault(x => x.Id == id);

            //Если такого не существует
            if (student == null)
                return NotFound(); // возвращаем результат 404 Not Found

            return View(student);
        }
    }
}