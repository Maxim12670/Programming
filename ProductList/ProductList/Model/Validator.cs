using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProductList.Model
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда число меньше нуля.</exception>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if(value < 0)
            {
                throw new ArgumentException(message: $"Error in {propertyName} - can't be negative");
            }
        }

        /// <summary>
        /// Проверяет, состоит ли строка только из букв английского алфавита.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда в строке появляются недопустимые символы.</exception>
        public static void CheckString(string value, string propertyName)
        {
            for (var i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException($"{propertyName} must contains letters only");
                }
            }
        }
    }
}
