using System;

namespace Ex5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Homework 5");
            var homeworkObject = new Homework();
            homeworkObject.E1();
            homeworkObject.E2();
            homeworkObject.E3();
            homeworkObject.E4();
            homeworkObject.E5();
            homeworkObject.E6();
            Console.WriteLine("\nEnd of Homework 5. Press any key to end.");
            Console.ReadKey();
        }
    }
}
