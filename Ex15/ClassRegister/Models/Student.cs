using System.Collections.Generic;

namespace ClassRegister.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }
        public List<Course> Courses { get; set; }
    }
}