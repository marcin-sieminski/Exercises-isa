using MVC_EFC_App.Models;
using System.Linq;

namespace MVC_EFC_App.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if (context.Teachers.Any())
            {
                return;
            }

            var teachers = new Teacher[]
            {
                new Teacher{FirstName = "Adam",LastName = "Abacki", Subject = "Matematyka"}, 
                new Teacher{FirstName = "Magdalena",LastName = "Nowak", Subject = "Polski"}, 
                new Teacher{FirstName = "Wojciech",LastName = "Kowalski", Subject = "Fizyka"}, 
                new Teacher{FirstName = "Mariola",LastName = "Cabacka", Subject = "Historia"}
            };

            foreach (Teacher teacher in teachers)
            {
                context.Teachers.Add(teacher);
            }

            context.SaveChanges();
        }
    }
}
