using System;
using System.Collections.Generic;

namespace MVC_EFC_App.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Class { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Grade> Grades { get; set;}
    }
}
