using System;
using System.IO;

namespace Ex7
{
    class FileWriter : IWriter
    {
        public void Write(string textToWrite)
        {
            Console.WriteLine("Please provide full path to a text file to write:");
            var path = Console.ReadLine();
            File.WriteAllText(path, textToWrite);
        }
    }
}
