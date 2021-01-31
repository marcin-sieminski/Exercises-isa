using Microsoft.AspNetCore.Mvc;
using MVC_EFC_App.Interfaces;
using MVC_EFC_App.Models;
using System.Data;

namespace MVC_EFC_App.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeachersController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public IActionResult Index()
        {
            return View(_teacherRepository.GetTeachers());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = _teacherRepository.GetTeacherById(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,FirstName,LastName,Subject")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _teacherRepository.InsertTeacher(teacher);
                _teacherRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = _teacherRepository.GetTeacherById(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,FirstName,LastName,Subject")] Teacher teacher)
        {
            if (id != teacher.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _teacherRepository.UpdateTeacher(teacher);
                    _teacherRepository.Save();
                }
                catch (DataException)
                {
                    ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
                }
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = _teacherRepository.GetTeacherById(id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _teacherRepository.DeleteTeacher(id);
            _teacherRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        protected override void Dispose(bool disposing)
        {
            _teacherRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
