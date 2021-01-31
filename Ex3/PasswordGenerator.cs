using System;

namespace Ex3
{
    public static class PasswordGenerator
    {
        public static string GeneratePassword(int minChars, int maxChars)
        {
            var random = new Random();
            var length = random.Next(minChars, maxChars + 1);
            return RandomStringGenerator.CreateRandomString(length);
        }
    }
}
