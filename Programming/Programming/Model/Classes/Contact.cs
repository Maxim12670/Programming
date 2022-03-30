using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;

        public Contact()
        {
        }

        public Contact(string name,
                       string city,
                       string address,
                       string phoneNumber)
        {
            Name = name;
            City = city;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
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
    }
}
