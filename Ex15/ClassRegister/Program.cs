using System;

namespace ClassRegister
{
    class Program
    {
        public static void Main()
        {
            var classRegister = new ClassRegister();
            int selection;

            do
            {
                Console.Clear();
                Console.WriteLine("Class register".ToUpper());
                Console.WriteLine("\nSelect action: \n[0] Add student \n[1] Add teacher \n[2] Add curse \n[3] Get best students \n[4] Get all students \n[5] Add mark \n[9] Close");

                int.TryParse(Console.ReadLine(), out selection);
                switch (selection)
                {
                    case 0:
                        classRegister.AddStudent();
                        break;
                    case 1:
                        classRegister.AddTeacher();
                        break;
                    case 2:
                        classRegister.AddCourse();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("List of best students:\n");
                        foreach (var student in classRegister.GetStudentsWithBestAverage())
                        {
                            Console.WriteLine(student.Name);
                        }
                        Helpers.Helpers.WaitUntilKeyPressed();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("List of all students:\n");
                        foreach (var student in classRegister.GetAllStudents())
                        {
                            Console.WriteLine(student.Name);
                        }
                        Helpers.Helpers.WaitUntilKeyPressed();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Course id:  ");
                        var courseId = int.Parse(Console.ReadLine() ?? string.Empty);
                        Console.WriteLine("Mark: ");
                        var mark = int.Parse(Console.ReadLine() ?? string.Empty);
                        classRegister.AddMark(courseId, mark);
                        Helpers.Helpers.WaitUntilKeyPressed();
                        break;
                    case 6:
                        break;
                }
            } while (selection != 9);
        }
    }
}
