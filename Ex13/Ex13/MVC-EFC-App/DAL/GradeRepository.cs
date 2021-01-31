using Microsoft.EntityFrameworkCore;
using MVC_EFC_App.Data;
using MVC_EFC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_EFC_App.DAL
{
    public class GradeRepository : IGradeRepository, IDisposable
    {
        private readonly SchoolContext _context;

        public GradeRepository(SchoolContext context)
        {

            _context = context;
        }

        public IEnumerable<Grade> GetGrades()
        {
            return _context.Grades.Include(x => x.Student).ToList();;
        }

        public Grade GetGradeById(int? id)
        {
            return _context.Grades.Find(id);
        }

        public void InsertGrade(Grade grade)
        {
            _context.Grades.Add(grade);
        }

        public void DeleteGrade(int id)
        {
            Grade grade = GetGradeById(id);
            _context.Grades.Remove(grade);
        }

        public void UpdateGrade(Grade grade)
        {
            _context.Entry(grade).State = EntityState.Modified;
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
