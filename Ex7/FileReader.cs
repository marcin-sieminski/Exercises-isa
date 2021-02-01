using System;
using System.IO;

namespace Ex7
{
    public class FileReader : IReader
    {
        public string ReadText()
        {
            Console.WriteLine("Please provide full path to a text file to read:");
            var path = Console.ReadLine();
            using var stream = new StreamReader(path);
            var text = stream.ReadToEnd();
            return text;
        }
    }
}
