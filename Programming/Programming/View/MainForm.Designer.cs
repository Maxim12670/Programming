namespace Programming.View
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.EnumerationsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputWeekdayLabel = new System.Windows.Forms.Label();
            this.ParseWeekdayButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.ParsingLabel = new System.Windows.Forms.Label();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnamLabel = new System.Windows.Forms.Label();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.EnumerationsTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.EnumerationsTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1367, 633);
            this.tabControl.TabIndex = 0;
            // 
            // EnumerationsTabPage
            // 
            this.EnumerationsTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumerationsTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnumerationsTabPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnumerationsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumerationsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.EnumerationsTabPage.Name = "EnumerationsTabPage";
            this.EnumerationsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.EnumerationsTabPage.Size = new System.Drawing.Size(1359, 604);
            this.EnumerationsTabPage.TabIndex = 1;
            this.EnumerationsTabPage.Text = "Enums";
            this.EnumerationsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonHandleGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(675, 314);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(680, 286);
            this.SeasonHandleGroupBox.TabIndex = 8;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(181, 44);
            this.GoButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(100, 29);
            this.GoButton.TabIndex = 9;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(12, 47);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(160, 24);
            this.SeasonComboBox.TabIndex = 10;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(8, 28);
            this.SeasonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(110, 17);
            this.SeasonLabel.TabIndex = 9;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.OutputWeekdayLabel);
            this.WeekdayGroupBox.Controls.Add(this.ParseWeekdayButton);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.ParsingLabel);
            this.WeekdayGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeekdayGroupBox.Location = new System.Drawing.Point(4, 314);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(663, 286);
            this.WeekdayGroupBox.TabIndex = 7;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // OutputWeekdayLabel
            // 
            this.OutputWeekdayLabel.AutoSize = true;
            this.OutputWeekdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputWeekdayLabel.Location = new System.Drawing.Point(33, 95);
            this.OutputWeekdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputWeekdayLabel.Name = "OutputWeekdayLabel";
            this.OutputWeekdayLabel.Size = new System.Drawing.Size(0, 25);
            this.OutputWeekdayLabel.TabIndex = 8;
            // 
            // ParseWeekdayButton
            // 
            this.ParseWeekdayButton.Location = new System.Drawing.Point(307, 46);
            this.ParseWeekdayButton.Margin = new System.Windows.Forms.Padding(4);
            this.ParseWeekdayButton.Name = "ParseWeekdayButton";
            this.ParseWeekdayButton.Size = new System.Drawing.Size(100, 29);
            this.ParseWeekdayButton.TabIndex = 7;
            this.ParseWeekdayButton.Text = "Parse";
            this.ParseWeekdayButton.UseVisualStyleBackColor = true;
            this.ParseWeekdayButton.Click += new System.EventHandler(this.ParseWeekdayButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(8, 49);
            this.WeekdayTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WeekdayTextBox.Multiline = true;
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(291, 27);
            this.WeekdayTextBox.TabIndex = 6;
            // 
            // ParsingLabel
            // 
            this.ParsingLabel.AutoSize = true;
            this.ParsingLabel.Location = new System.Drawing.Point(8, 28);
            this.ParsingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ParsingLabel.Name = "ParsingLabel";
            this.ParsingLabel.Size = new System.Drawing.Size(154, 17);
            this.ParsingLabel.TabIndex = 6;
            this.ParsingLabel.Text = "Type value for parsing:";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.EnamLabel);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumerationsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(4, 4);
            this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(1351, 310);
            this.EnumerationsGroupBox.TabIndex = 6;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // EnamLabel
            // 
            this.EnamLabel.AutoSize = true;
            this.EnamLabel.Location = new System.Drawing.Point(5, 23);
            this.EnamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnamLabel.Name = "EnamLabel";
            this.EnamLabel.Size = new System.Drawing.Size(143, 17);
            this.EnamLabel.TabIndex = 1;
            this.EnamLabel.Text = "Choose enumeration:";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(420, 23);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(65, 17);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(8, 44);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(199, 244);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(423, 44);
            this.IntValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.ReadOnly = true;
            this.IntValueTextBox.Size = new System.Drawing.Size(245, 22);
            this.IntValueTextBox.TabIndex = 4;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(216, 44);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(199, 244);
            this.ValuesListBox.TabIndex = 2;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(213, 22);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(98, 17);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 633);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.tabControl.ResumeLayout(false);
            this.EnumerationsTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage EnumerationsTabPage;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label EnamLabel;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.Label OutputWeekdayLabel;
        private System.Windows.Forms.Button ParseWeekdayButton;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Label ParsingLabel;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Button GoButton;
    }
}

