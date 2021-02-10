using System.ComponentModel;

namespace MVC_EFC_App.Models
{
    public class Grade
    {
        public int Id { get; set; }
        [DisplayName("Grade number")]
        public int GradeNumber { get; set; }
        [DisplayName("Grade description")]
        public string GradeDescription { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

    }
}
