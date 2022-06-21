
namespace ProductList
{
    partial class ProductListForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListForm));
            this.ProductListBox = new System.Windows.Forms.ListBox();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.SelectedProductGroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SelectedProductGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductListBox
            // 
            this.ProductListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.ItemHeight = 20;
            this.ProductListBox.Location = new System.Drawing.Point(12, 37);
            this.ProductListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(255, 284);
            this.ProductListBox.TabIndex = 0;
            this.ProductListBox.SelectedIndexChanged += new System.EventHandler(this.ProductListBox_SelectedIndexChanged);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductLabel.Location = new System.Drawing.Point(8, 9);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(93, 25);
            this.ProductLabel.TabIndex = 1;
            this.ProductLabel.Text = "Product:";
            // 
            // SelectedProductGroupBox
            // 
            this.SelectedProductGroupBox.Controls.Add(this.NameLabel);
            this.SelectedProductGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedProductGroupBox.Controls.Add(this.CategoryComboBox);
            this.SelectedProductGroupBox.Controls.Add(this.QuantityTextBox);
            this.SelectedProductGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.SelectedProductGroupBox.Controls.Add(this.QuantityLabel);
            this.SelectedProductGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectedProductGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SelectedProductGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedProductGroupBox.Location = new System.Drawing.Point(272, 37);
            this.SelectedProductGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectedProductGroupBox.Name = "SelectedProductGroupBox";
            this.SelectedProductGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectedProductGroupBox.Size = new System.Drawing.Size(516, 298);
            this.SelectedProductGroupBox.TabIndex = 2;
            this.SelectedProductGroupBox.TabStop = false;
            this.SelectedProductGroupBox.Text = "Selected Product";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameLabel.Location = new System.Drawing.Point(67, 47);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(58, 20);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(156, 39);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(352, 30);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(156, 143);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(352, 33);
            this.CategoryComboBox.TabIndex = 6;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityTextBox.Location = new System.Drawing.Point(156, 106);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(352, 30);
            this.QuantityTextBox.TabIndex = 5;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerTextBox.Location = new System.Drawing.Point(156, 73);
            this.ManufacturerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(352, 30);
            this.ManufacturerTextBox.TabIndex = 3;
            this.ManufacturerTextBox.TextChanged += new System.EventHandler(this.ManufacturerTextBox_TextChanged);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.QuantityLabel.Location = new System.Drawing.Point(45, 113);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(76, 20);
            this.QuantityLabel.TabIndex = 2;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(40, 149);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(81, 20);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category:";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(5, 79);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(113, 20);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "Manufacturer:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = global::ProductList.Properties.Resources.iconDelete;
            this.DeleteButton.Location = new System.Drawing.Point(189, 347);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(77, 71);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.MouseEnter += new System.EventHandler(this.DeleteButton_MouseEnter);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.DeleteButton_MouseLeave);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::ProductList.Properties.Resources.iconAdd;
            this.AddButton.Location = new System.Drawing.Point(12, 347);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(77, 71);
            this.AddButton.TabIndex = 3;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SelectedProductGroupBox);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.ProductListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ProductListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            this.SelectedProductGroupBox.ResumeLayout(false);
            this.SelectedProductGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductListBox;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.GroupBox SelectedProductGroupBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
    }
}

