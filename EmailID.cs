using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class EmailID
    {
        public string Regex_Pattern = "^[abc]{3}[.]{1}[a-z]{3}[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]{2,}$";
        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Pattern);
        }
    }
}
