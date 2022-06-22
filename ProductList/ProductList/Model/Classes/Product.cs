using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductList.Model.Enums;

namespace ProductList.Model.Classes
{
    public class Product
    {
        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Название производителя.
        /// </summary>
        private string _manufacturer;

        /// <summary>
        /// Количество товара на складе.
        /// </summary>
        private int _quantity;

        /// <summary>
        /// Создает экземпляр класса <see cref="Product"/>.
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Product"/>.
        /// </summary>
        /// <param name="name">Название товара. Должно состоять из букв английского алфавита.</param>
        /// <param name="manufacturer">Название производителя. Должно состоять из букв английского алфавита.</param>
        /// <param name="quantity">Количество на складе. Целое положительное число.</param>
        /// <param name="category">Категория товара.</param>
        public Product(string name,
                        string manufacturer,
                        int quantity,
                        ProductCategories category)
        {
            Name = name;
            Manufacturer = manufacturer;
            Quantity = quantity;
            Category = category;
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public ProductCategories Category { get; set; }

        /// <summary>
        /// Возвращает и задает название товара.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.CheckString(value, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название производителя.
        /// </summary>
        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                Validator.CheckString(value, nameof(Manufacturer));
                _manufacturer = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество товара на складе.
        /// </summary>
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Quantity));
                _quantity = value;
            }
        }
    }
}
