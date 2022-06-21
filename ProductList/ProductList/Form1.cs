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

        private List<Product> _allProduct = new List<Product>();

        public ProductListForm()
        {
            InitializeComponent();
            _product = new Product();
            NameTextBox.Text = "";
            ManufacturerTextBox.Text = "";
            QuantityTextBox.Text = "";
            var productCategories = Enum.GetValues(typeof(ProductCategories));

            foreach (var value in productCategories)
            {
                CategoryComboBox.Items.Add(value);
            }
            CategoryComboBox.SelectedIndex = 0;
        }

        //private void CheckTextBox()
        //{
        //    string name = NameTextBox.Text;
        //    string manufacturer = ManufacturerTextBox.Text;
        //    string quantity = (QuantityTextBox.Text).ToString();
        //    Color colorName = NameTextBox.BackColor;
        //    Color colorManufacturer = ManufacturerTextBox.BackColor;
        //    Color colorQuantity = QuantityTextBox.BackColor;
        //    if(name.Length == 0 ||
        //       manufacturer.Length == 0 ||
        //       quantity == null)
        //    {
        //        DialogResult result = MessageBox.Show(
        //                                        "Check fields!",
        //                                        "Message",
        //                                         MessageBoxButtons.OK,
        //                                         MessageBoxIcon.Warning);
        //    }
        //    else if( colorName == _errorColor ||
        //            colorManufacturer == _errorColor ||
        //            colorQuantity == _errorColor)
        //    {
        //        DialogResult result = MessageBox.Show(
        //                                        "Check fields!",
        //                                        "Message",
        //                                        MessageBoxButtons.OK,
        //                                        MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        var product = AddProduct();
        //    }
    
            
        //}

 

        private Product AddProduct()
        {
            //_product = new Product();

            //_product.Name = NameTextBox.Text;
            //_product.Manufacturer = ManufacturerTextBox.Text;
            //_product.Quantity = int.Parse(QuantityTextBox.Text);
            //_product.Category = CategoryComboBox.Text;

            //_allProduct.Add(_product);

            //ProductListBox.Items.Add(_product.Name);
            //return _product;
            _product = new Product();
            _allProduct = new List<Product>();
            _product.Name = NameTextBox.Text;
            _product.Manufacturer = ManufacturerTextBox.Text;
            _product.Quantity = int.Parse(QuantityTextBox.Text);
            _product.Category = CategoryComboBox.Text;

            string name = NameTextBox.Text;
            string manufacturer = ManufacturerTextBox.Text;
            string quantity = (QuantityTextBox.Text).ToString();
            Color colorName = NameTextBox.BackColor;
            Color colorManufacturer = ManufacturerTextBox.BackColor;
            Color colorQuantity = QuantityTextBox.BackColor;

            if (name.Length == 0 ||
               manufacturer.Length == 0 ||
               quantity == null)
            {
                DialogResult result = MessageBox.Show(
                                                "Check fields!",
                                                "Message",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Warning);
            }
            else if (colorName == _errorColor ||
                    colorManufacturer == _errorColor ||
                    colorQuantity == _errorColor)
            {
                DialogResult result = MessageBox.Show(
                                                "Check fields!",
                                                "Message",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
            }
            

            _allProduct.Add(_product);

            ProductListBox.Items.Add(_product.Name);

            return _product;
            


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

        private void AddButton_Click(object sender, EventArgs e)
        {
            //CheckTextBox();
            var product = AddProduct();
            //ProductListBox.SelectedIndex = ProductListBox.Items.Count - 1;

            ClearInfoText();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductListBox.SelectedIndex != -1)
            {
                int index = ProductListBox.SelectedIndex;
                _allProduct.RemoveAt(index);
                ProductListBox.Items.RemoveAt(index);

                if (ProductListBox.SelectedIndex == -1)
                {
                    ClearInfoText();
                }
                if (_allProduct.Count != 0)
                {
                    ProductListBox.SelectedIndex = index - 1;
                }
            }
        }

        private void ProductListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = ProductListBox.SelectedIndex;
            _product = _allProduct[index];
            NameTextBox.Text = _product.Name.ToString();
            ManufacturerTextBox.Text = _product.Manufacturer.ToString();
            QuantityTextBox.Text = _product.Quantity.ToString();
            CategoryComboBox.Text = _product.Category.ToString();


        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string name = NameTextBox.Text;
                _product.Name = name;
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
