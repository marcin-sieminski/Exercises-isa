namespace MVC_EFC_App.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int GradeNumber { get; set; }
        public string GradeDescription { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

    }
}
