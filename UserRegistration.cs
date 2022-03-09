using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class UserRegistration
    {
        public static string Regex_Pattern = "^[A-Z]{1}[a-z]{3,10}$";
        public bool ValidateName (string Name)
        {
            return Regex.IsMatch(Name, Regex_Pattern);
        }
    }
}
