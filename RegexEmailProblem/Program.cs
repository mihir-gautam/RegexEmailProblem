using System;

namespace RegexEmailProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Regex Email pattern problem");
            Pattern pattern = new Pattern();
            bool x = true;
            while (x)
            {
                Console.WriteLine("Enter the email id whose validity needs to be checked");
                string EmailId = Console.ReadLine();
                pattern.validateEmail(EmailId);
                continue;
            }
            x = false;
        }
    }
}
