using System;

namespace Ex7
{
    class ConsoleWriter : IWriter
    {
        public void Write(string textToWrite)
        {
            Console.WriteLine(textToWrite);
        }
    }
}
