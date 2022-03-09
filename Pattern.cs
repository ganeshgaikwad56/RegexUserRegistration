using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Pattern
    {
        public static string Regex_Pattern = @"^(91[' '])[7-9]{1}[0-9]{9}$";

        public bool ValidateMobileNumber(string number)
        {
            return Regex.IsMatch(number, Regex_Pattern);
        }

    }
}
