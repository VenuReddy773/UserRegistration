using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration\n");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Validate Program\n 1.First Name\n 2.Last Name\n 3.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Validation FirstName = new Validation();
                        Console.WriteLine("Enter the First Name to Check Validation:");
                        string input = Console.ReadLine();
                        FirstName.ValidateFirstName(input);
                        break;
                    case 2:
                        Validation LastName = new Validation();
                        Console.WriteLine("Enter the Last Name to Check Validation:");
                        string Last = Console.ReadLine();
                        LastName.ValidateLastName(Last);
                        break;                   
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
