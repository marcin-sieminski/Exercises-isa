using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_EFC_App.Interfaces;
using MVC_EFC_App.Models;
using System.Data;

namespace MVC_EFC_App.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ITeacherRepository _teacherRepository;

        public StudentsController(IStudentRepository studentRepository, ITeacherRepository teacherRepository)
        {
            _studentRepository = studentRepository;
            _teacherRepository = teacherRepository;
        }

        public IActionResult Index()
        {
            return View(_studentRepository.GetStudents());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _studentRepository.GetStudentById(id);

            if (student == null)
            {
                return NotFound();
            }
            ViewData["TeacherId"] = new SelectList(_teacherRepository.GetTeachers(), "Id", "Id");
            return View(student);
        }

        public IActionResult Create()
        {
            ViewData["TeacherId"] = new SelectList(_teacherRepository.GetTeachers(), "Id", "Id");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,FirstName,LastName,BirthDate,Class,TeacherId")] Student student)
        {
            if (ModelState.IsValid)
            {
                _studentRepository.InsertStudent(student);
                _studentRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TeacherId"] = new SelectList(_teacherRepository.GetTeachers(), "Id", "Id", student.TeacherId);
            return View(student);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _studentRepository.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewData["TeacherId"] = new SelectList(_teacherRepository.GetTeachers(), "Id", "Id");
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,FirstName,LastName,BirthDate,Class,TeacherId")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _studentRepository.UpdateStudent(student);
                    _studentRepository.Save();
                }
                catch (DataException)
                {
                    ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TeacherId"] = new SelectList(_teacherRepository.GetTeachers(), "Id", "Id", student.TeacherId);
            return View(student);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _studentRepository.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewData["TeacherId"] = new SelectList(_teacherRepository.GetTeachers(), "Id", "Id");
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _studentRepository.DeleteStudent(id);
            _studentRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        protected override void Dispose(bool disposing)
        {
            _studentRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
