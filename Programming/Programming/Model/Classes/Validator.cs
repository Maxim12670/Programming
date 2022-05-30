using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
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
             if (value < 0)
             {
                throw new ArgumentException(message: $"Error in {propertyName} - can't be negative");
             }
        }

        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда число меньше нуля.</exception>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException(message: $"Error in {propertyName} - can't be negative");
            }
        }

        /// <summary>
        /// роверяет, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (min > value | max < value)
            {
                throw new ArgumentException(message: $"Error in {propertyName} - not in range");
            }
        }

        /// <summary>
        /// роверяет, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (min > value | max < value)
            {
                throw new ArgumentException(message: $"Error in {propertyName} - not in range");
            }
        }  
    }
}
