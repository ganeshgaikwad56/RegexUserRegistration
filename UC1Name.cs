using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaDemo
{
    public class UC1Name
    {
       public string FirstName = "^[A-Z][a-z]{2,}$";
        public string FirstnameCheckusingLambda(string firstName) => Regex.IsMatch(firstName, FirstName) ? "FirstName is Valid" : "FirstName is not Valid";
        
    }

}
   
