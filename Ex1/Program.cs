using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            bool correctInput = true;
            decimal? memory = null;
            int numberOfOperands = 2;

            do
            {
                Console.Clear();
                Console.WriteLine("Advanced Calculator v1.0");
                Console.WriteLine("Enter 'm' to add value to memory or use memorized value.");
                Console.WriteLine();

                Console.WriteLine(memory != null ? $"Memory: {memory.Value}" : "Nothing in memory.");
                Console.WriteLine();

                var values = new decimal[numberOfOperands];

                try
                {
                    for (var i = 0; i < values.Length; i++)
                    {
                        Console.Write($"Enter value {i+1}: ");
                        var input = Console.ReadLine();

                        if (input.ToLower().Contains('m'))
                        {
                            if (memory != null)
                            {
                                Console.Write($"Value in memory: {memory.Value}. Use it? (y/n) ");
                                if (Console.ReadLine().ToLower().Equals("y"))
                                {
                                    values[i] = memory.Value;
                                }
                                else
                                {
                                    Console.Write($"Enter value {i+1} (and put into memory): ");
                                    correctInput = decimal.TryParse(Console.ReadLine(), out values[i]);
                                    if (correctInput)
                                    {
                                        memory = values[i];
                                    }
                                }
                            }
                            else
                            {
                                Console.Write($"Nothing in memory. Enter value {i+1} (and put into memory): ");
                                correctInput = decimal.TryParse(Console.ReadLine(), out values[i]);
                                if (correctInput)
                                {
                                    memory = values[i];
                                }
                            }
                        }
                        else
                        {
                            correctInput = decimal.TryParse(input, out values[i]);
                        }

                        if (!correctInput)
                        {
                            throw new ArgumentException();
                        }
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect value. Press any key to try again.");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Choose operator (+ - * / %): ");
                var operation = Console.ReadLine();
                decimal result;

                switch (operation)
                {
                    case "+":
                        result = values[0] + values[1];
                        break;
                    case "-":
                        result = values[0] - values[1];
                        break;
                    case "*":
                        result = values[0] * values[1];
                        break;
                    case "/":
                        try
                        {
                            result = values[0] / values[1];
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Divide by zero not allowed. Press any key to try again.");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    case "%":
                        result = values[0] % values[1];
                        break;
                    default:
                        Console.WriteLine("Incorrect operator. Press any key to try again.");
                        Console.ReadKey();
                        continue;
                }

                Console.WriteLine();
                Console.WriteLine($"Value 1: {values[0]}");
                Console.WriteLine($"Value 2: {values[1]}");
                Console.WriteLine(memory != null ? $"Memory: {memory.Value}" : "Nothing in memory.");

                Console.WriteLine();
                Console.WriteLine("Your calculation:");
                Console.WriteLine($"{values[0]} {operation} {values[1]} = {result}");

                Console.WriteLine();
                Console.Write("Would you like to perform next calculation? (y/n) ");
                if (Console.ReadLine().ToLower().Equals("n"))
                {
                    repeat = false;
                }
            } while (repeat);
        }
    }
}
