namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            this.HeightSelectedTextBox = new System.Windows.Forms.TextBox();
            this.HeightSelectedLabel = new System.Windows.Forms.Label();
            this.WidthSelectedTextBox = new System.Windows.Forms.TextBox();
            this.WidthSelectedLabel = new System.Windows.Forms.Label();
            this.YSelectedTextBox = new System.Windows.Forms.TextBox();
            this.YSelectedLabel = new System.Windows.Forms.Label();
            this.XSelectedTextBox = new System.Windows.Forms.TextBox();
            this.XSelectedLabel = new System.Windows.Forms.Label();
            this.IdSelectedTextBox = new System.Windows.Forms.TextBox();
            this.IdSelectedLabel = new System.Windows.Forms.Label();
            this.SelectedLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.RectanglesSelectedListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesPanel.Location = new System.Drawing.Point(427, 3);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(738, 627);
            this.RectanglesPanel.TabIndex = 31;
            // 
            // HeightSelectedTextBox
            // 
            this.HeightSelectedTextBox.Location = new System.Drawing.Point(73, 488);
            this.HeightSelectedTextBox.Name = "HeightSelectedTextBox";
            this.HeightSelectedTextBox.Size = new System.Drawing.Size(100, 22);
            this.HeightSelectedTextBox.TabIndex = 30;
            this.HeightSelectedTextBox.TextChanged += new System.EventHandler(this.HeightSelectedTextBox_TextChanged);
            // 
            // HeightSelectedLabel
            // 
            this.HeightSelectedLabel.AutoSize = true;
            this.HeightSelectedLabel.Location = new System.Drawing.Point(12, 491);
            this.HeightSelectedLabel.Name = "HeightSelectedLabel";
            this.HeightSelectedLabel.Size = new System.Drawing.Size(53, 17);
            this.HeightSelectedLabel.TabIndex = 29;
            this.HeightSelectedLabel.Text = "Height:";
            // 
            // WidthSelectedTextBox
            // 
            this.WidthSelectedTextBox.Location = new System.Drawing.Point(73, 460);
            this.WidthSelectedTextBox.Name = "WidthSelectedTextBox";
            this.WidthSelectedTextBox.Size = new System.Drawing.Size(100, 22);
            this.WidthSelectedTextBox.TabIndex = 28;
            this.WidthSelectedTextBox.TextChanged += new System.EventHandler(this.WidthSelectedTextBox_TextChanged);
            // 
            // WidthSelectedLabel
            // 
            this.WidthSelectedLabel.AutoSize = true;
            this.WidthSelectedLabel.Location = new System.Drawing.Point(17, 460);
            this.WidthSelectedLabel.Name = "WidthSelectedLabel";
            this.WidthSelectedLabel.Size = new System.Drawing.Size(48, 17);
            this.WidthSelectedLabel.TabIndex = 27;
            this.WidthSelectedLabel.Text = "Width:";
            // 
            // YSelectedTextBox
            // 
            this.YSelectedTextBox.Location = new System.Drawing.Point(73, 432);
            this.YSelectedTextBox.Name = "YSelectedTextBox";
            this.YSelectedTextBox.Size = new System.Drawing.Size(100, 22);
            this.YSelectedTextBox.TabIndex = 26;
            this.YSelectedTextBox.TextChanged += new System.EventHandler(this.YSelectedTextBox_TextChanged);
            // 
            // YSelectedLabel
            // 
            this.YSelectedLabel.AutoSize = true;
            this.YSelectedLabel.Location = new System.Drawing.Point(44, 434);
            this.YSelectedLabel.Name = "YSelectedLabel";
            this.YSelectedLabel.Size = new System.Drawing.Size(21, 17);
            this.YSelectedLabel.TabIndex = 25;
            this.YSelectedLabel.Text = "Y:";
            // 
            // XSelectedTextBox
            // 
            this.XSelectedTextBox.Location = new System.Drawing.Point(73, 404);
            this.XSelectedTextBox.Name = "XSelectedTextBox";
            this.XSelectedTextBox.Size = new System.Drawing.Size(100, 22);
            this.XSelectedTextBox.TabIndex = 24;
            this.XSelectedTextBox.TextChanged += new System.EventHandler(this.XSelectedTextBox_TextChanged);
            // 
            // XSelectedLabel
            // 
            this.XSelectedLabel.AutoSize = true;
            this.XSelectedLabel.Location = new System.Drawing.Point(44, 406);
            this.XSelectedLabel.Name = "XSelectedLabel";
            this.XSelectedLabel.Size = new System.Drawing.Size(21, 17);
            this.XSelectedLabel.TabIndex = 23;
            this.XSelectedLabel.Text = "X:";
            // 
            // IdSelectedTextBox
            // 
            this.IdSelectedTextBox.Location = new System.Drawing.Point(73, 376);
            this.IdSelectedTextBox.Name = "IdSelectedTextBox";
            this.IdSelectedTextBox.ReadOnly = true;
            this.IdSelectedTextBox.Size = new System.Drawing.Size(100, 22);
            this.IdSelectedTextBox.TabIndex = 22;
            // 
            // IdSelectedLabel
            // 
            this.IdSelectedLabel.AutoSize = true;
            this.IdSelectedLabel.Location = new System.Drawing.Point(44, 379);
            this.IdSelectedLabel.Name = "IdSelectedLabel";
            this.IdSelectedLabel.Size = new System.Drawing.Size(23, 17);
            this.IdSelectedLabel.TabIndex = 21;
            this.IdSelectedLabel.Text = "Id:";
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.AutoSize = true;
            this.SelectedLabel.Location = new System.Drawing.Point(3, 356);
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(135, 17);
            this.SelectedLabel.TabIndex = 20;
            this.SelectedLabel.Text = "Selected Rectangle:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(98, 298);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 37);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.MouseEnter += new System.EventHandler(this.DeleteButton_MouseEnter);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.DeleteButton_MouseLeave);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(6, 298);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 37);
            this.AddButton.TabIndex = 18;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(3, 3);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(83, 17);
            this.RectanglesLabel.TabIndex = 17;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // RectanglesSelectedListBox
            // 
            this.RectanglesSelectedListBox.FormattingEnabled = true;
            this.RectanglesSelectedListBox.ItemHeight = 16;
            this.RectanglesSelectedListBox.Location = new System.Drawing.Point(6, 23);
            this.RectanglesSelectedListBox.Name = "RectanglesSelectedListBox";
            this.RectanglesSelectedListBox.Size = new System.Drawing.Size(415, 260);
            this.RectanglesSelectedListBox.TabIndex = 16;
            this.RectanglesSelectedListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesSelectedListBox_SelectedIndexChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesPanel);
            this.Controls.Add(this.HeightSelectedTextBox);
            this.Controls.Add(this.HeightSelectedLabel);
            this.Controls.Add(this.WidthSelectedTextBox);
            this.Controls.Add(this.WidthSelectedLabel);
            this.Controls.Add(this.YSelectedTextBox);
            this.Controls.Add(this.YSelectedLabel);
            this.Controls.Add(this.XSelectedTextBox);
            this.Controls.Add(this.XSelectedLabel);
            this.Controls.Add(this.IdSelectedTextBox);
            this.Controls.Add(this.IdSelectedLabel);
            this.Controls.Add(this.SelectedLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.RectanglesSelectedListBox);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(1168, 633);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RectanglesPanel;
        private System.Windows.Forms.TextBox HeightSelectedTextBox;
        private System.Windows.Forms.Label HeightSelectedLabel;
        private System.Windows.Forms.TextBox WidthSelectedTextBox;
        private System.Windows.Forms.Label WidthSelectedLabel;
        private System.Windows.Forms.TextBox YSelectedTextBox;
        private System.Windows.Forms.Label YSelectedLabel;
        private System.Windows.Forms.TextBox XSelectedTextBox;
        private System.Windows.Forms.Label XSelectedLabel;
        private System.Windows.Forms.TextBox IdSelectedTextBox;
        private System.Windows.Forms.Label IdSelectedLabel;
        private System.Windows.Forms.Label SelectedLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.ListBox RectanglesSelectedListBox;
    }
}
