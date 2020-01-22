using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Al_Web_Store.Infrastructure.Interfaces;
using HomeTask_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeTask_1.Controllers
{
    [Route("users")]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [Route("all")]
        public IActionResult Index()
        {
            return View(_studentService.GetAll());
        }

        [Route("{id}")]
        public IActionResult Details(int id)
        {
            var student = _studentService.GetById(id);

            //Если такого не существует
            if (student == null)
                return NotFound(); // возвращаем результат 404 Not Found

            return View(student);
        }

        /// <summary>
        /// Добавление или редактирование студента
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return View(new StudentView());

            StudentView model = _studentService.GetById(id.Value);
            if (model == null)
                return NotFound();// возвращаем результат 404 Not Found

            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]

        public IActionResult Edit(StudentView model)
        {
            if (model.Id > 0) // если есть Id, то редактируем модель
            {
                var dbItem = _studentService.GetById(model.Id);

                if (ReferenceEquals(dbItem, null))
                    return NotFound();// возвращаем результат 404 Not Found

                dbItem.FirstName = model.FirstName;
                dbItem.SurName = model.SurName;
                dbItem.Age = model.Age;
                dbItem.Course = model.Course;
                dbItem.Telefon = model.Telefon;
            }
            else // иначе добавляем модель в список
            {
                _studentService.AddNew(model);
            }
            _studentService.Commit(); // станет актуальным позднее (когда добавим БД)

            return RedirectToAction(nameof(Index));
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}