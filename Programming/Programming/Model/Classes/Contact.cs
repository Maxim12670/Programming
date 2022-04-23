using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;

        private string _name;

        private string _surname;

        public Contact()
        {
        }

        public Contact(string name,
                       string surname,
                       string city,
                       string address,
                       string phoneNumber)
        {
            Name = name;
            Surname = surname;
            City = city;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public string City { get; set; }

        public string Address { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException(message: "Phone number must contain 11 digits!");
                }
                
                if (int.TryParse(value, out int num) == false)
                {
                    throw new ArgumentException(message: "The number can only contain numbers!");
                }

                _phoneNumber = value;
            }
        }

        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            Regex regex = new Regex(@"^[A-Z][a-z]*[a-z]$");
            MatchCollection matches = regex.Matches(value);
            if (matches.Count != 0)
            {
                throw new ArgumentException(message: $"Error in {propertyName}!");
            } 
        }
    }
}
