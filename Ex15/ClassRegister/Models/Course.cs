using System.Collections.Generic;

namespace ClassRegister.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public List<int> Marks { get; set; }
    }
}