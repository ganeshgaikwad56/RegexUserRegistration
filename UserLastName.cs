using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class UserLastName
    {
        public string Regex_Pattern = "^[A-Z]{1}[a-z]{3,}$";

        public bool validateLastName (string UserLastName)
        {
            return Regex.IsMatch(UserLastName, Regex_Pattern);
        }
    }
}
