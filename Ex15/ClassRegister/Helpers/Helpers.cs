using System;

namespace ClassRegister.Helpers
{
    public static class Helpers
    {
        public static int InputPersonalData(out string name, out string surname, out string street, out int number, out string zipcode,
            out string email)
        {
            Console.WriteLine("Please provide personal data:");

            Console.WriteLine("Id: ");
            int.TryParse(Console.ReadLine(), out var id);
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Street: ");
            street = Console.ReadLine();
            Console.WriteLine("Number: ");
            int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Zipcode: ");
            zipcode = Console.ReadLine();
            Console.WriteLine("Email: ");
            email = Console.ReadLine();
            return id;
        }

        public static int InputCourseData(out string name, out int teacherId, out int studentId)
        {
            Console.WriteLine("Please provide course data:");

            Console.WriteLine("Course Id: ");
            int.TryParse(Console.ReadLine(), out var courseId);
            Console.WriteLine("Course name: ");
            name = Console.ReadLine();
            Console.WriteLine("Teacher Id: ");
            int.TryParse(Console.ReadLine(), out teacherId);
            Console.WriteLine("Student Id: ");
            int.TryParse(Console.ReadLine(), out studentId);
            return courseId;
        }

        public static void WaitUntilKeyPressed()
        {
            Console.WriteLine("\nPress any key to go back.");
            Console.ReadKey();
        }
    }
}
