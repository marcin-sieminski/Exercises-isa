using System;
using System.Collections.Generic;

namespace Ex3
{
    internal class UserAccountsConsoleUi
    {
        public static DateTime ApplicationStartDateTime { get; private set; }
        public List<UserAccount> UsersList { get; } = new List<UserAccount>();
        private bool _runApplication;

        public UserAccountsConsoleUi()
        {
            ApplicationStartDateTime = DateTime.Now;
            _runApplication = true;
        }

        public void StartApplication()
        {
            while (_runApplication)
            {
                DisplayMenu();
            }
            ExitProgram();
        }

        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("User Accounts Application");
            Console.WriteLine();
            var menuDictionary = new Dictionary<string, string>()
            {
                {"1.", "Create new user"},
                {"2.", "Display users"},
                {"3.", "Delete user"},
                {"4.", "Exit program"}
            };

            foreach (var menuItem in menuDictionary)
            {
                Console.WriteLine(menuItem.Key.PadRight(5) + menuItem.Value);
            }

            int valueEntered;
            do
            {
                Console.Write("\nChoose 1 - 4: ");
            } while (!int.TryParse(Console.ReadLine(), out valueEntered));

            switch (valueEntered)
            {
                case 1:
                    CreateNewUser();
                    break;
                case 2:
                    DisplayUsers();
                    break;
                case 3:
                    DeleteUser();
                    break;
                case 4:
                    _runApplication = false;
                    break;
                default:
                    Console.WriteLine("\nIncorrect value entered.");
                    return;
            }
        }

        private void DeleteUser()
        {
            Console.WriteLine("\nDeleting user - enter email to delete user: ");
            var emailToDelete = Console.ReadLine();
            try
            {
                for (var i = 0; i < UsersList.Count; i++)
                {
                    if (UsersList[i].Email == emailToDelete)
                    {
                        UsersList.RemoveAt(i);
                        Console.WriteLine("\nUser deleted. Press any key to continue.");
                        Console.ReadKey();
                        return;
                    }
                }
                throw new ArgumentException("Provided email is not on the list", $"email");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\nDeleting user failed.");
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
        }

        private void DisplayUsers()
        {
            Console.WriteLine($"\n{UsersList.Count} user(s) present:\n");
            Console.WriteLine("#".PadRight(4) + "Name".PadRight(13) + "Last Name".PadRight(20) + "Email".PadRight(25) + "Age".PadRight(8) + "IsActive".PadRight(10) + "Password".PadRight(35));
            Console.WriteLine("===================================================================================================================");
            var currentUserNumber = 1;
            foreach (var userAccount in UsersList)
            {
                
                Console.WriteLine($"{(currentUserNumber++.ToString()+ ".").PadRight(4)}{userAccount.FirstName.PadRight(13)}{userAccount.LastName.PadRight(20)}{userAccount.Email.PadRight(25)}{userAccount.Age.ToString().PadRight(8)}{userAccount.IsActive.ToString().PadRight(10)}{userAccount.Password.PadRight(35)}");
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        private void CreateNewUser()
        {
            Console.WriteLine("\nPlease enter required user data:\n");
            Console.Write("First name: ");
            var firstName = Console.ReadLine();
            Console.Write("Last name: ");
            var lastName = Console.ReadLine();
            Console.Write("Age: ");
            int.TryParse(Console.ReadLine(), out var age);
            try
            {
                UsersList.Add(new UserAccount(firstName, lastName, age, EmailGenerator.GenerateEmail(firstName, lastName, "@example.com", UsersList)));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("\nCreating user aborted.");
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("\nUser created! Press any key to return.");
            Console.ReadKey();
        }

        private void ExitProgram()
        {
            TimeSpan intervalApplicationRunningTime = DateTime.Now - ApplicationStartDateTime;
            Console.WriteLine($"\nApplication was running for {intervalApplicationRunningTime.Minutes} minute(s) and {intervalApplicationRunningTime.Seconds} second(s).");
            Console.WriteLine($"{UsersList.Count} user(s) present. Press any key to exit.");
            Console.ReadKey();
        }
    }
}