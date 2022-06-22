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

namespace ProductList
{
    public partial class ProductListForm : Form
    {
        private readonly Color _correctColor = Color.White;

        private readonly Color _errorColor = Color.Red;

        private Product _product;

        private List<Product> _allProduct ;

        public ProductListForm()
        {
            InitializeComponent();
            _allProduct = new List<Product>();
            var productCategories = Enum.GetValues(typeof(ProductCategories));

            foreach (var value in productCategories)
            {
                CategoryComboBox.Items.Add(value);
            }
            CategoryComboBox.SelectedIndex = 0;
        }

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
            _allProduct.Add(_product);
            ProductListBox.Items.Add(_product.Name);
        }

        private void UpdateProductInfo(Product product)
        {
            NameTextBox.Text = product.Name;
            ManufacturerTextBox.Text = product.Manufacturer;
            QuantityTextBox.Text = product.Quantity.ToString();
            CategoryComboBox.Text = product.Category.ToString();           
        }

        private void UpdateListBoxInfo()
        {
            int index = ProductListBox.SelectedIndex;
            ProductListBox.Items[index] = _product.Name;           
        }


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

        private void SortNameProduct()
        {
            _allProduct = _allProduct.OrderBy(product => product.Name).ToList();
            ProductListBox.Items.Clear();
            foreach (var product in _allProduct)
            {
                ProductListBox.Items.Add(product.Name);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {         
            AddProduct();
            _allProduct = _allProduct.OrderBy(product => product.Name).ToList();
            SortNameProduct();
            ProductListBox.SelectedIndex = _allProduct.Count-1;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductListBox.SelectedIndex != -1)
            {
                int index = ProductListBox.SelectedIndex;
                _allProduct.RemoveAt(index);
                ProductListBox.Items.Clear();

                foreach (var product in _allProduct)
                    ProductListBox.Items.Add(product.Name);
                ProductListBox.SelectedIndex = _allProduct.Count - 1;
                ClearInfoText();
                SortNameProduct();
            }
        }

        private void ProductListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductListBox.SelectedIndex == -1) return;
            int index = ProductListBox.SelectedIndex;
            _product = _allProduct[index];
            NameTextBox.Text = _product.Name;
            ManufacturerTextBox.Text = _product.Manufacturer;
            QuantityTextBox.Text = _product.Quantity.ToString();
            CategoryComboBox.Text = _product.Category.ToString();
            UpdateProductInfo(_product);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _product.Name = NameTextBox.Text;
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

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = global::ProductList.Properties.Resources.iconAddGreen;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = global::ProductList.Properties.Resources.iconAdd;
        }

        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton.Image = global::ProductList.Properties.Resources.iconDeleteRed;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.Image = global::ProductList.Properties.Resources.iconDelete;
        }
    }
}
