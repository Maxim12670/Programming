using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductList.Model.Classes;
using ProductList.Model.Enums;
using Newtonsoft.Json;

namespace ProductList
{
    public partial class ProductListForm : Form
    {
        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Выбранный элемент.
        /// </summary>
        private Product _product;

        /// <summary>
        /// Коллекция элементов.
        /// </summary>
        private List<Product> _allProducts;

        /// <summary>
        /// Создает экземпляр класса <see cref="ProductListForm"/>. 
        /// </summary>
        public ProductListForm()
        {
            InitializeComponent();
            _allProducts = Serializer.Deserialize();
            foreach(var value in _allProducts)
            {
                ProductListBox.Items.Add(value.Name);
            }

            var productCategories = Enum.GetValues(typeof(ProductCategories));

            foreach (var value in productCategories)
            {
                CategoryComboBox.Items.Add(value);
            }
            CategoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Добавялет новый элемент.
        /// </summary>
        private void AddProduct()
        {
            _product = new Product();
            _product.Name = "Name";
            _product.Manufacturer = "Manufacturer";
            _product.Quantity = 100;
            _product.Category = (ProductCategories) CategoryComboBox.SelectedItem;
            string name = NameTextBox.Text; 
            string manufacturer = ManufacturerTextBox.Text;
            string quantity = QuantityTextBox.Text;
            Color colorName = NameTextBox.BackColor;
            Color colorManufacturer = ManufacturerTextBox.BackColor;
            Color colorQuantity = QuantityTextBox.BackColor;
            _allProducts.Add(_product);
            ProductListBox.Items.Add(_product.Name);
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
        /// <param name="product"></param>
        private void UpdateProductInfo(Product product)
        {
            NameTextBox.Text = product.Name;
            ManufacturerTextBox.Text = product.Manufacturer;
            QuantityTextBox.Text = product.Quantity.ToString();
            CategoryComboBox.Text = product.Category.ToString();           
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
        private void UpdateListBoxInfo()
        {
            int index = ProductListBox.SelectedIndex;
            ProductListBox.Items[index] = _product.Name;           
        }

        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
        private void ClearInfoText()
        {
            NameTextBox.Clear();
            NameTextBox.BackColor = _correctColor;
            ManufacturerTextBox.Clear();
            ManufacturerTextBox.BackColor = _correctColor;
            QuantityTextBox.Clear();
            QuantityTextBox.BackColor = _correctColor;
            CategoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Сортирует по имени.
        /// </summary>
        private void SortProduct()
        {
            var products = _allProducts.OrderBy(product => product.Name).ToList();
            _allProducts = products;
            ProductListBox.Items.Clear();
            foreach (var product in products)
            {
                ProductListBox.Items.Add(product.Name);
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddProduct();
            SortProduct();
            ProductListBox.SelectedIndex = 0;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductListBox.SelectedIndex != -1)
            {
                int index = ProductListBox.SelectedIndex;
                _allProducts.RemoveAt(index);
                ProductListBox.Items.Clear();
                SortProduct();
                //foreach (var product in _allProducts)
                //    ProductListBox.Items.Add(product.Name);
                ClearInfoText();
            }
        }

        private void ProductListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductListBox.SelectedIndex == -1) return;
            int index = ProductListBox.SelectedIndex;
            _product = _allProducts[index];
            NameTextBox.Text = _product.Name;
            ManufacturerTextBox.Text = _product.Manufacturer;
            QuantityTextBox.Text = _product.Quantity.ToString();
            CategoryComboBox.Text = _product.Category.ToString();
            UpdateProductInfo(_product);
            //ProductListBox.SelectedItem = _allProducts.Count - 1;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _product.Name = NameTextBox.Text;

                SortProduct();
                UpdateListBoxInfo();
            }
            catch
            {
                NameTextBox.BackColor = _errorColor;
                return;
            }
            NameTextBox.BackColor = _correctColor;
             
        }

        private void ManufacturerTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string manufacturer = ManufacturerTextBox.Text;
                _product.Manufacturer = manufacturer;
            }
            catch
            {
                ManufacturerTextBox.BackColor = _errorColor;
                return;
            }
            ManufacturerTextBox.BackColor = _correctColor;
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string quantity = Convert.ToString(QuantityTextBox.Text);
                int quantityValue = int.Parse(quantity);
                _product.Quantity = quantityValue;
            }
            catch
            {
                QuantityTextBox.BackColor = _errorColor;
                return;
            }
            QuantityTextBox.BackColor = _correctColor;
        }
        private void ProductListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.Serialize(_allProducts);
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = global::ProductList.Properties.Resources.AddGreen;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = global::ProductList.Properties.Resources.Add;
        }

        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton.Image = global::ProductList.Properties.Resources.DeleteRed;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.Image = global::ProductList.Properties.Resources.Delete;
        }
    }
}
