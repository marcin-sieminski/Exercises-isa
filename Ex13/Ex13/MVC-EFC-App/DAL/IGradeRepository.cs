using MVC_EFC_App.Models;
using System;
using System.Collections.Generic;

namespace MVC_EFC_App.DAL
{
    public interface IGradeRepository : IDisposable
    {
        IEnumerable<Grade> GetGrades();
        Grade GetGradeById(int? id);
        void InsertGrade(Grade grade);
        void DeleteGrade(int id);
        void UpdateGrade(Grade grade);
        void Save();
    }
}
