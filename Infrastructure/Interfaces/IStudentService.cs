using HomeTask_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Al_Web_Store.Infrastructure.Interfaces
{
    /// <summary>
    /// Интерфейс для работы со студентами
    /// </summary>
    public interface IStudentService
    {
        /// <summary>
        /// Получение списка студентов
        /// </summary>
        /// <returns></returns>
        IEnumerable<StudentView> GetAll();

        /// <summary>
        /// Получение студента по id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        StudentView GetById(int id);

        /// <summary>
        /// Сохранить изменения
        /// </summary>
        void Commit();

        /// <summary>
        /// Добавить нового
        /// </summary>
        /// <param name="model"></param>
        void AddNew(StudentView model);

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
