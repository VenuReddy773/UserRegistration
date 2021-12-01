﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validation
    {
        public string First_Name = "^[A-Z]{1}[A-Za-z]{3,}$";
        public string Last_Name = "^[A-Z]{1}[A-Za-z]{3,}$";
        public string Email = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        public string Mobile = "^[0-9]{2}[ ]{1}[0-9]{10}$";
        public void ValidateFirstName(string name)
        {
            Regex regex = new Regex(First_Name);
            bool check = regex.IsMatch(name);
            if (check)
            {
                Console.WriteLine("Valid First Name\n");
            }
            else
            {
                Console.WriteLine("Invalid!!");
            }
        }
        public void ValidateLastName(string name)
        {
            Regex regex = new Regex(Last_Name);
            bool check = regex.IsMatch(name);
            if (check)
            {
                Console.WriteLine("Valid Last Name\n");
            }
            else
            {
                Console.WriteLine("Invalid!!");
            }
        }
        public void ValidateEmail(string mail)
        {
            Regex regex = new Regex(Email);
            bool check = regex.IsMatch(mail);
            if (check)
            {
                Console.WriteLine("Valid Mail Address\n");
            }
            else
            {
                Console.WriteLine("Invalid!!");
            }
        }
        public void ValidateMobile(string number)
        {
            Regex regex = new Regex(Mobile);
            bool check = regex.IsMatch(number);
            if (check)
            {
                Console.WriteLine("Valid Mobile Number\n");
            }
            else
            {
                Console.WriteLine("Invalid!!");
            }
        }
    }
}