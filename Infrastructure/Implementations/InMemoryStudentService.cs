using Al_Web_Store.Infrastructure.Interfaces;
using HomeTask_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Al_Web_Store.Infrastructure.Implementations
{
    public class InMemoryStudentService : IStudentService
    {
        private readonly List<StudentView> _student;

        public InMemoryStudentService()
        {
            _student = new List<StudentView>
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
        }

        public void AddNew(StudentView model)
        {
            if (_student.Count > 0)
                model.Id = _student.Max(e => e.Id) + 1;
            else
                model.Id = 1;
            _student.Add(model);
        }

        public void Commit()
        {
            // в дальнейшем сделаем
        }

        public void Delete(int id)
        {
            var student = GetById(id);
            if (student != null)
            {
                _student.Remove(student);
            }
        }

        public IEnumerable<StudentView> GetAll()
        {
            return _student;
        }

        public StudentView GetById(int id)
        {
            return _student.FirstOrDefault(e => e.Id.Equals(id));
        }
    }

}
