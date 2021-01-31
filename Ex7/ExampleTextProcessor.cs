using System;

namespace Ex7
{
    public class ExampleTextProcessor
    {
        public string ProcessedText { get; private set; }

        public ExampleTextProcessor()
        {
            Initialize();
        }

        private void Initialize()
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
            IReader reader = null;
            switch (Console.ReadLine())
            {
                case "1":
                    reader = new ConsoleReader();
                    break;
                case "2":
                    reader = new FileReader();
                    break;
            }
            ProcessedText = reader?.ReadText();
        }

        public void Process()
        {
            Console.WriteLine("\nPlease choose a processing method:");
            Console.WriteLine("1. All uppercase");
            Console.WriteLine("2. All lowercase");
            IProcessor processor = null;
            switch (Console.ReadLine())
            {
                case "1":
                    processor = new UppercaseProcessor();
                    break;
                case "2":
                    processor = new LowercaseProcessor();
                    break;
            }
            ProcessedText = processor?.ProcessText(ProcessedText);
        }

        public void Write()
        {
            Console.WriteLine("Please choose a destination to write processed text:");
            Console.WriteLine("1. Console");
            Console.WriteLine("2. File");
            IWriter writer = null;
            switch (Console.ReadLine())
            {
                case "1":
                    writer = new ConsoleWriter();
                    break;
                case "2":
                    writer = new FileWriter();
                    break;
            }
            writer?.Write(ProcessedText);
        }
    }
}