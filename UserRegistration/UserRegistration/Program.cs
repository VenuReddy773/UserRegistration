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
                Console.WriteLine("Enter your Choice Number to Validate Program\n 1.First Name\n 2.Last Name\n 3.Email\n 4.Mobile Number\n 5.Password\n 6.PasswordRule2\n 7.PasswordRule3\n 8.Exit\n");
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
                        Validation mail = new Validation();
                        Console.WriteLine("Enter the Email Address for Validation:");
                        string Email = Console.ReadLine();
                        mail.ValidateEmail(Email);
                        break;
                    case 4:
                        Validation num = new Validation();
                        Console.WriteLine("Enter the Mobile Number for Validation:");
                        string number = Console.ReadLine();
                        num.ValidateMobile(number);
                        break;
                    case 5:
                        Validation rule = new Validation();
                        Console.WriteLine("Enter the Password for Validation:");
                        string password = Console.ReadLine();
                        rule.ValidateRuleOne(password);
                        break;
                    case 6:
                        Validation ruletwo = new Validation();
                        Console.WriteLine("Enter the Password for Validation:");
                        string passwordtwo = Console.ReadLine();
                        ruletwo.ValidateRuleTwo(passwordtwo);
                        break;
                    case 7:
                        Validation rulethree = new Validation();
                        Console.WriteLine("Enter the Password for Validation:");
                        string passwordthree = Console.ReadLine();
                        rulethree.ValidateRuleThree(passwordthree);
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}
