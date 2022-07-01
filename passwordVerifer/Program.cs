using passwordVerifer;

namespace PasswordVerifier
{
    internal class PasswordVerifier
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password");
            var password = Console.ReadLine();
           var valid = verifier.VerifyPassword(password);
            if(valid)
            {
                Console.WriteLine("Password is Valid");
            }
        }
    }
}