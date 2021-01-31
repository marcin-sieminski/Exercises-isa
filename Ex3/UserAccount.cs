﻿using System;

namespace Ex3
{
    public class UserAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value >= 18 && value <= 65)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"age", "Only users between 18 and 65 years old are allowed.");
                }
            }
        }

        public string Email { get; }
        public string Password { get; }
        public bool IsActive { get; set; }

        public UserAccount(string firstName, string lastName, int age, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Password = PasswordGenerator.GeneratePassword(16, 32);
            IsActive = true;
        }
    }
}
