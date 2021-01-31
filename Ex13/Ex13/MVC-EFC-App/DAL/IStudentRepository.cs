using MVC_EFC_App.Models;
using System;
using System.Collections.Generic;

namespace MVC_EFC_App.Interfaces
{
    public interface IStudentRepository : IDisposable
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int? id);
        void InsertStudent(Student student);
        void DeleteStudent(int id);
        void UpdateStudent(Student student);
        void Save();
    }
}
