using System;

namespace Ex7
{
    public class Program
    {
        public static void Main()
        {
            var textProcessor = new ExampleTextProcessor();
            textProcessor.Read();
            textProcessor.Process();
            textProcessor.Write();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
