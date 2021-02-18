using ClassRegister.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClassRegister
{
    public class ClassRegister
    {
        private readonly List<Student> _students = new();
        private readonly List<Teacher> _teachers = new();
        private readonly List<Course> _courses = new();
        private const double GoodAverage = 4.75;

        public void AddStudent()
        {
            var id = Helpers.Helpers.InputPersonalData(out var name, out var surname, out var street, out var number, out var zipcode, out var email);

            _students.Add(new Student
            {
                Id = id,
                Name = name,
                Surname = surname,
                Address = new Address
                {
                    Street = street,
                    Number = number,
                    Zipcode = zipcode,
                    Email = email
                },
                Courses = new List<Course>()
            });
        }

        public void AddTeacher()
        {
            var id = Helpers.Helpers.InputPersonalData(out var name, out var surname, out var street, out var number, out var zipcode, out var email);

            _teachers.Add(new Teacher
            {
                Id = id,
                Name = name,
                Surname = surname,
                Address = new Address()
                {
                    Street = street,
                    Number = number,
                    Zipcode = zipcode,
                    Email = email
                }
            });
        }

        public void AddCourse()
        {
            var courseId = Helpers.Helpers.InputCourseData(out var name, out var teacherId, out var studentId);

            _courses.Add(new Course
            {
                Id = courseId,
                Name = name,
                TeacherId = teacherId,
                StudentId = studentId,
                Marks = new List<int>()
            });
        }

        public void AddMark(int courseId, int mark)
        {
            _courses.First(course => course.Id == courseId).Marks.Add(mark);
        }

        public IEnumerable<Student> GetStudentsWithBestAverage()
        {
            return (from student in _students from course in student.Courses let studentAverage = course.Marks.Average() where studentAverage > GoodAverage select student).ToList();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }
    }
}
