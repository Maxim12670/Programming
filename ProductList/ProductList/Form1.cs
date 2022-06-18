using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductList
{
    public partial class ProductListForm : Form
    {


        public ProductListForm()
        {
            InitializeComponent();
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = global::ProductList.Properties.Resources.iconAddGreen;
            //AddButton.Image = System.Drawing.Image.FromFile(@"C:\Users\Максим\Desktop\reposit\ProductList\ProductList\Icons");
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
