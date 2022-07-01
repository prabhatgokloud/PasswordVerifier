using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordVerifer
{
    public static class verifier

    {
        static int MinPassLength = 8;
        public static bool VerifyPassword(string password)
        {

            bool isValid = true;
            try
            {
                var exceptions = new List<Exception>();
                if (string.IsNullOrWhiteSpace(password))
                {
                    isValid = false;
                    exceptions.Add(new Exception("\npassword cannot be empty"));
                }
                if (password.Length <= MinPassLength)
                {
                    isValid = false;
                    exceptions.Add(new Exception("\nPassword should be greater than " + MinPassLength + " letters\n"));
                }
                if (!password.Any(char.IsLower))
                {
                    isValid = false;
                    exceptions.Add(new Exception("\nPassword should have atleast one lowerCase letter"));
                }
                if (!password.Any(char.IsUpper))
                {
                    isValid = false;
                    exceptions.Add(new Exception("\npassword should have atleast one uppercase letter"));
                }
                if (!password.Any(char.IsDigit))
                {
                    isValid = false;
                    exceptions.Add(new Exception("\npassword should have atleast one uppercase Digit"));
                }
                if (exceptions.Count > 0)
                {
                    throw new AggregateException(exceptions);
                }
                return isValid;

            }
            catch (AggregateException e)
            {

                Console.WriteLine(e.Message);
            }
            return isValid;


        }
    }
}
