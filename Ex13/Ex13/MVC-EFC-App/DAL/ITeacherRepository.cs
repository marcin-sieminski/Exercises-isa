using MVC_EFC_App.Models;
using System;
using System.Collections.Generic;

namespace MVC_EFC_App.Interfaces
{
    public interface ITeacherRepository : IDisposable
    {
        IEnumerable<Teacher> GetTeachers();
        Teacher GetTeacherById(int? id);
        void InsertTeacher(Teacher teacher);
        void DeleteTeacher(int id);
        void UpdateTeacher(Teacher teacher);
        void Save();
    }
}
