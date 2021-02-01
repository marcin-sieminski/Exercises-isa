using System;

namespace Ex7
{
    public class ExampleTextProcessor
    {
        private string ProcessedText { get; set; }

        public ExampleTextProcessor()
        {
            Initialize();
        }

        private static void Initialize()
        {
            Console.Clear();
            Console.WriteLine("\n-------------------------------------\n");
            Console.WriteLine("Welcome to Text Processor!");
            Console.WriteLine("\n-------------------------------------\n");
        }

        public void Read()
        {
            Console.WriteLine("Please choose a source of text to process:");
            Console.WriteLine("1. Input from the console");
            Console.WriteLine("2. File");
            IReader reader = Console.ReadLine() switch
            {
                "1" => new ConsoleReader(),
                "2" => new FileReader(),
                _ => null
            };
            ProcessedText = reader?.ReadText();
        }

        public void Process()
        {
            Console.WriteLine("\nPlease choose a processing method:");
            Console.WriteLine("1. All uppercase");
            Console.WriteLine("2. All lowercase");
            IProcessor processor = Console.ReadLine() switch
            {
                "1" => new UppercaseProcessor(),
                "2" => new LowercaseProcessor(),
                _ => null
            };
            ProcessedText = processor?.ProcessText(ProcessedText);
        }

        public void Write()
        {
            Console.WriteLine("Please choose a destination to write processed text:");
            Console.WriteLine("1. Console");
            Console.WriteLine("2. File");
            IWriter writer = Console.ReadLine() switch
            {
                "1" => new ConsoleWriter(),
                "2" => new FileWriter(),
                _ => null
            };
            writer?.Write(ProcessedText);
        }
    }
}