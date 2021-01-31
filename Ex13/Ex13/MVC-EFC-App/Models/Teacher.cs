using System.Collections.Generic;

namespace MVC_EFC_App.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
