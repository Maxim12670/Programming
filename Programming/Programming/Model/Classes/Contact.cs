using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _nameHuman;
        private string _city;
        private string _address;
        private string _phoneNumber;

        public Contact()
        {
        }

        public Contact(string nameHuman,
                       string city,
                       string address,
                       string phoneNumber)
        {
            NameHuman = nameHuman;
            City = city;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        
        public string NameHuman { get; set; }
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
                    throw new ArgumentException(message:"Телефонный номер должен содержать 11 цифр!");
                }
                
                if (int.TryParse(value, out int num) == false)
                {
                    throw new ArgumentException(message: "Номер может содержать только цифры!");
                }

                _phoneNumber = value;
            }
        }
    }
}
