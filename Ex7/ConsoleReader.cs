using System;

namespace Ex7
{
    public class ConsoleReader : IReader
    {
        public string ReadText()
        {
            Console.WriteLine("Please input your text below:");
            var textFromConsole = Console.ReadLine();
            return textFromConsole;
        }
    }
}
