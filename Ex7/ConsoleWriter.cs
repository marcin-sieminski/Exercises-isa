using System;

namespace Ex7
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string textToWrite)
        {
            Console.WriteLine(textToWrite);
        }
    }
}
