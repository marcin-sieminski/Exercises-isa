using Microsoft.EntityFrameworkCore;
using MVC_EFC_App.Data;
using MVC_EFC_App.Interfaces;
using MVC_EFC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_EFC_App.Repositories
{
    public class StudentRepository : IStudentRepository, IDisposable
    {
        private readonly SchoolContext _context;

        public StudentRepository(SchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Students.Include(x => x.Teacher).ToList();
        }

        public Student GetStudentById(int? id)
        {
            return _context.Students.Find(id);
        }

        public void InsertStudent(Student student)
        {
            _context.Students.Add(student);
        }

        public void DeleteStudent(int id)
        {
            Student student = GetStudentById(id);
            _context.Students.Remove(student);
        }

        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
