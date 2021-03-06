﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexEmailProblem
{
    class Pattern
    {
        string Regex_Email = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,})?$";
        public void validateEmail(string email)
        {
            if (Regex.IsMatch(email, Regex_Email))
            { 
                Console.WriteLine("The email id is valid");
            }
            else
            {
                Console.WriteLine("email id is not valid");
            }
        }
    }
}
