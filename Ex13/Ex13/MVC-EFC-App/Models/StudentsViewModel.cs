using System.Collections.Generic;

namespace MVC_EFC_App.Models
{
    public class StudentsViewModel
    {
        public IEnumerable<Student> Students { get; init; }
        public IEnumerable<Teacher> Teachers { get; init; }
    }
}
