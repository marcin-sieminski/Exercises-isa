using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_EFC_App.DAL;
using MVC_EFC_App.Interfaces;
using System.Data;

namespace MVC_EFC_App.Models
{
    public class GradesController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IGradeRepository _gradeRepository;

        public GradesController(IStudentRepository studentRepository, IGradeRepository gradeRepository)
        {
            _studentRepository = studentRepository;
            _gradeRepository = gradeRepository;
        }

        public IActionResult Index()
        {
            return View(_gradeRepository.GetGrades());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grade = _gradeRepository.GetGradeById(id);
            if (grade == null)
            {
                return NotFound();
            }
            ViewData["StudentId"] = new SelectList(_studentRepository.GetStudents(), "Id", "Id");
            return View(grade);
        }

        public IActionResult Create()
        {
            ViewData["StudentId"] = new SelectList(_studentRepository.GetStudents(), "Id", "Id");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,GradeNumber,GradeDescription,StudentId")] Grade grade)
        {
            if (ModelState.IsValid)
            {
                _gradeRepository.InsertGrade(grade);
                _gradeRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudentId"] = new SelectList(_studentRepository.GetStudents(), "Id", "Id", grade.StudentId);
            return View(grade);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grade = _gradeRepository.GetGradeById(id);
            if (grade == null)
            {
                return NotFound();
            }
            ViewData["StudentId"] = new SelectList(_studentRepository.GetStudents(), "Id", "Id", grade.StudentId);
            return View(grade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,GradeNumber,GradeDescription,StudentId")] Grade grade)
        {
            if (id != grade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _gradeRepository.UpdateGrade(grade);
                    _gradeRepository.Save();
                }
                catch (DataException)
                {
                    ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudentId"] = new SelectList(_studentRepository.GetStudents(), "Id", "Id", grade.StudentId);
            return View(grade);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grade = _gradeRepository.GetGradeById(id);
            if (grade == null)
            {
                return NotFound();
            }
            ViewData["StudentId"] = new SelectList(_studentRepository.GetStudents(), "Id", "Id");
            return View(grade);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _gradeRepository.DeleteGrade(id);
            _gradeRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        protected override void Dispose(bool disposing)
        {
            _studentRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
