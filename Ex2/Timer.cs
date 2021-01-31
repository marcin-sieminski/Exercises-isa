using System;
using System.Threading;
using System.Collections.Generic;

namespace Ex2
{
    public class Timer
    {
        public int CountdownTime { get; private set; }

        public Timer()
        {

        }

        public Timer(int seconds)
        {
            CountdownTime = seconds;
            TimerCount(CountdownTime);
        }

        public void StartTimer()
        {
            ConsoleKeyInfo startAgainTimer;
            do
            {
                CountdownTime = SetTime();
                if (CountdownTime == 0)
                {
                    Console.WriteLine("\nTimer ended. Press any key to exit.");
                    Console.ReadKey();
                    return;
                }

                TimerCount(CountdownTime);
                
                Console.Write("\nStart timer again? (y/n): ");
                startAgainTimer = Console.ReadKey();
            } while(startAgainTimer.KeyChar == 'y');

            Console.WriteLine("\nTimer ended. Press any key to exit.");
            Console.ReadKey();
        }

        private void TimerCount(in int timeSeconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(timeSeconds);
            Console.WriteLine($"\nTime to countdown (M:S): {time:mm\\:ss}. Countdown started:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;
            for (int i = 0; i <= timeSeconds; i++)
            {
                Console.Write($"{TimeSpan.FromSeconds(timeSeconds - i):mm\\:ss}\r");
                Thread.Sleep(1000); 
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nTime is up!");
            Console.ForegroundColor = ConsoleColor.White;
            PlaySound();
            Console.CursorVisible = true;
        }

        private int SetTime()
        {
            Console.Clear();
            Console.WriteLine("Welcome to TIMER!");
            Console.WriteLine("\nChoose time to countdown (0 - exit):\n");
            var countTimeDictionary = new Dictionary<int, string>
            {
                {1, "5 seconds"},
                {2, "15 seconds"},
                {3, "30 seconds"},
                {4, "1 minute"},
                {5, "3 minutes"},
                {6, "5 minutes"},
                {7, "Set own time"},
                {0, "Exit"}
            };

            foreach (var countTime in countTimeDictionary)
            {
                Console.WriteLine($"{countTime.Key} : \t{countTime.Value}");
            }

            int valueEntered;
            do
            {
                Console.Write("\nPlease choose an option: ");
            } while (!int.TryParse(Console.ReadLine(), out valueEntered));

            switch (valueEntered)
            {
                case 1:
                    return 5;
                case 2:
                    return 15;
                case 3:
                    return 30;
                case 4:
                    return 60;
                case 5:
                    return 180;
                case 6:
                    return 300;
                case 7:
                    int ownTime;
                    do
                    {
                        Console.Write("\nEnter own time to countdown (in seconds): ");
                    } while (!int.TryParse(Console.ReadLine(), out ownTime));
                    return ownTime;
                case 0:
                    return 0;
                default:
                    Console.WriteLine("\nIncorrect value entered.");
                    return 0;
            }
        }

        private void PlaySound()
        {
            for (int j = 1; j <= 2; j++)
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.Beep(1500,400);
                    Thread.Sleep(50);
                }
                for (int i = 1; i < 4; i++)
                {
                    Console.Beep(2000,400);
                    Thread.Sleep(50);
                }
            }
        }
    }
}
