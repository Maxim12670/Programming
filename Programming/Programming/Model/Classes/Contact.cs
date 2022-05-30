using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контактных данных человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Должно состоять только из букв английского алфавита.</param>
        /// <param name="surname">Имя. Должно состоять только из букв английского алфавита.</param>
        /// <param name="city"></param>
        /// <param name="address"></param>
        /// <param name="phoneNumber">Номер. Должен состоять только из цифр.
        /// Должен иметь одиннадцать символов.</param>
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

        /// <summary>
        /// Возвращает и задает город контакта.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Возвращает и задает адрес контакта.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя контакта. Должно состоять только из букв английского алфавита.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт фамилию контакта. Должна состоять только из букв английского алфавита.
        /// </summary>
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


        /// <summary>
        /// Возвращает и задает номер контакта. Должен состоять только из цифр.
        /// Должен иметь одиннадцать символов.
        /// </summary>
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

        /// <summary>
        /// Проверяет строку на наличие английских букв.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
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
