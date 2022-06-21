using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProductList.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if(value < 0)
            {
                throw new ArgumentException(message: $"Error in {propertyName} - can't be negative");
            }
        }

        public static void CheckString(string value, string propertyName)
        {
            Regex regex = new Regex(@"^[A-Za-z]*[A-Za-z]$");
            MatchCollection matches = regex.Matches(value);
            if (matches.Count == 0)
            {
                throw new ArgumentException(message: $"Error in {propertyName}!");
            }
        }

    }
}
