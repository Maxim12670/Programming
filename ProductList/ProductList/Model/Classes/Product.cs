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
        private string _name;

        private string _manufacturer;

        private int _quantity;

        public Product()
        {
        }

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

        public ProductCategories Category { get; set; }

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
