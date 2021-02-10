using System.Collections.Generic;
using System.ComponentModel;

namespace MVC_EFC_App.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        public string LastName { get; set; }
        public string Subject { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
