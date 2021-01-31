using Microsoft.EntityFrameworkCore;
using MVC_EFC_App.Data;
using MVC_EFC_App.Interfaces;
using MVC_EFC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_EFC_App.DAL
{
    public class TeacherRepository : ITeacherRepository, IDisposable
    {
        private SchoolContext _context;

        public TeacherRepository(SchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Teacher> GetTeachers()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetTeacherById(int? id)
        {
            return _context.Teachers.Find(id);
        }

        public void InsertTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
        }

        public void DeleteTeacher(int id)
        {
            Teacher teacher = GetTeacherById(id);
            _context.Teachers.Remove(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _context.Entry(teacher).State = EntityState.Modified;
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
