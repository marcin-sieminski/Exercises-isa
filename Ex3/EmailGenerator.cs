using System.Collections.Generic;

namespace Ex3
{
    public static class EmailGenerator
    {
        public static string GenerateEmail(string firstName, string lastName, string emailDomain, List<UserAccount> usersList)
        {
            var nameString = firstName.ToLower().Substring(0, 2) + lastName.ToLower().Substring(0, 2);
            var domainString = emailDomain;
            var email = nameString + domainString;
            var numberToAdd = 1;
            foreach (var userAccount in usersList)
            {
                if (userAccount.Email == email)
                {
                    email = nameString + numberToAdd + domainString;
                    numberToAdd++;
                }
            }
            return email;
        }
    }
}
