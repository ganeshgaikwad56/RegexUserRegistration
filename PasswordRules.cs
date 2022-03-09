using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class PasswordRules
    {
        public static string Regex_Pattern = "^[A_Z]{1}[a-z]{4}[0-9]{3}$";
        public bool ValidatePass(string password)
        {
            return Regex.IsMatch(password, Regex_Pattern);
        }
    }
}
