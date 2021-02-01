using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5
{
    public class Homework
    {
        //TODO: Do każdej z metod dodaj wypisywanie wyniku na konsolę w czytelny i przejrzysty sposób ;)
        public void E1()
        {
            // Każdy z wyrazow „weź” w cudzysłów

            string[] words = new[] {"ala", "ma", "kota"};

            var e1Result = words.Select(x => $"\"{x}\"").ToList();

            PrintResultOnConsole(e1Result, 1);
        }


        public void E2()
        {
            // Znajdź takie słowa które zaczynają się na A i kończą na A. Wielkość liter nie ma znacznia.
            // 
            string[] words = new[] {"Ala", "ma", "kota", "beata", "ameba", "Amanda", "Albert"};

            //Wynik: Ala ameba Amanda
            var e2Result = words
                .Where(x => x.StartsWith("a", StringComparison.InvariantCultureIgnoreCase) && x.EndsWith("a", StringComparison.CurrentCultureIgnoreCase))
                .ToList();
            
            PrintResultOnConsole(e2Result, 2);
        }

        public void E3()
        {
            // Połącz liczby tak aby w rezultacie dały jeden string „0, 1, 2, 3, 4, 5” // zera nie ma w kolekcji celowo ;)

            int[] numbers = new[] {1, 2, 3, 4, 5};

            var e3Result = numbers.Aggregate("0", (s, number) => s + ", " + number);

            PrintResultOnConsole(e3Result, 3);
        }

        public void E4()
        {
            // Policz sumę liczb w tablicy (uwaga liczby są typu string)

            string[] numbersAsStrings = new[] {"1", "2", "3", "4"};

            //WyniK:  10 : int
            var e4Result = numbersAsStrings.Sum(int.Parse);

            PrintResultOnConsole(e4Result.ToString(), 4);
        }

        public void E5()
        {
            string votes = "Yes,No,Yes,Yes,Yes,No,No,Yes,Yes,No";

            //o ile więcej było głosów na 'tak' ?

            // Wynik: o 2 głosy.

            var countYes = votes
                .Split(',')
                .Count(x => x.Equals("Yes"));

            var countNo = votes
                .Split(',')
                .Count(x => x.Equals("No"));

            var result = countYes - countNo;

            PrintResultOnConsole(result.ToString(), 5);
        }

        public void E6()
        {
            // W jaki dzień tygodnia wypada
            // Wigilia Bożego Narodzenia przez
            // następne 5 lat (od 2021 do 2025 roku) ?

            // Wynik: Powinniśmy stworzyć kolekcję par: rok i dzień tygodnia czyli coś podobnego do:
            /*
             * 2021 Friday 
               2022 Saturday 
               2023 Sunday 
               2024 Tuesday 
               2025 Wednesday 
             */
            int[] years = new[]
            {
                2021, 2022, 2023, 2024, 2025
            };

            var christmasEve = years
                .Select(x => new { Year = x, ChristmasEveDay = new DateTime(x, 12, 24).DayOfWeek })
                .ToList();

            Console.WriteLine($"\nExercise 6:");
            foreach (var eve in christmasEve)
            {
                Console.WriteLine(eve.Year + " " + eve.ChristmasEveDay);
            }
        }

        private void PrintResultOnConsole(List<string> exerciseResult, int exerciseNumber)
        {
            Console.WriteLine($"\nExercise {exerciseNumber}:");
            foreach (var element in exerciseResult)
            {
                Console.WriteLine(element);
            }
        }

        private void PrintResultOnConsole(string exerciseResult, int exerciseNumber)
        {
            Console.WriteLine($"\nExercise {exerciseNumber}:");
            Console.WriteLine(exerciseResult);
        }
    }
}