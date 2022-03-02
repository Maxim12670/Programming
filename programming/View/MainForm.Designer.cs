
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EnumsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.WeekDayGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultDayLabel = new System.Windows.Forms.Label();
            this.NameActionLabel = new System.Windows.Forms.Label();
            this.WeekDayTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumerationLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.ResultSeasonLabel = new System.Windows.Forms.Label();
            this.EnumsTabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.WeekDayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.tabPage);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(789, 575);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.SeasonGroupBox);
            this.tabPage.Controls.Add(this.WeekDayGroupBox);
            this.tabPage.Controls.Add(this.EnumerationsGroupBox);
            this.tabPage.Location = new System.Drawing.Point(4, 25);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(781, 546);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Enums";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // WeekDayGroupBox
            // 
            this.WeekDayGroupBox.Controls.Add(this.ResultDayLabel);
            this.WeekDayGroupBox.Controls.Add(this.NameActionLabel);
            this.WeekDayGroupBox.Controls.Add(this.WeekDayTextBox);
            this.WeekDayGroupBox.Controls.Add(this.ParseButton);
            this.WeekDayGroupBox.Location = new System.Drawing.Point(8, 322);
            this.WeekDayGroupBox.Name = "WeekDayGroupBox";
            this.WeekDayGroupBox.Size = new System.Drawing.Size(376, 216);
            this.WeekDayGroupBox.TabIndex = 4;
            this.WeekDayGroupBox.TabStop = false;
            this.WeekDayGroupBox.Text = "Weekday  Parsing";
            // 
            // ResultDayLabel
            // 
            this.ResultDayLabel.AutoSize = true;
            this.ResultDayLabel.Location = new System.Drawing.Point(6, 72);
            this.ResultDayLabel.Name = "ResultDayLabel";
            this.ResultDayLabel.Size = new System.Drawing.Size(0, 17);
            this.ResultDayLabel.TabIndex = 3;
            // 
            // NameActionLabel
            // 
            this.NameActionLabel.AutoSize = true;
            this.NameActionLabel.Location = new System.Drawing.Point(3, 27);
            this.NameActionLabel.Name = "NameActionLabel";
            this.NameActionLabel.Size = new System.Drawing.Size(154, 17);
            this.NameActionLabel.TabIndex = 2;
            this.NameActionLabel.Text = "Type value for parsing:";
            // 
            // WeekDayTextBox
            // 
            this.WeekDayTextBox.Location = new System.Drawing.Point(6, 47);
            this.WeekDayTextBox.Multiline = true;
            this.WeekDayTextBox.Name = "WeekDayTextBox";
            this.WeekDayTextBox.Size = new System.Drawing.Size(226, 24);
            this.WeekDayTextBox.TabIndex = 1;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(238, 46);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 26);
            this.ParseButton.TabIndex = 0;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumerationLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(765, 310);
            this.EnumerationsGroupBox.TabIndex = 3;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(379, 40);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(65, 17);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(382, 60);
            this.IntValueTextBox.Multiline = true;
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(182, 26);
            this.IntValueTextBox.TabIndex = 2;

            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(194, 60);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(182, 212);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(191, 40);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(98, 17);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Choose value:";

            // 
            // EnumerationLabel
            // 
            this.EnumerationLabel.AutoSize = true;
            this.EnumerationLabel.Location = new System.Drawing.Point(3, 40);
            this.EnumerationLabel.Name = "EnumerationLabel";
            this.EnumerationLabel.Size = new System.Drawing.Size(143, 17);
            this.EnumerationLabel.TabIndex = 3;
            this.EnumerationLabel.Text = "Choose enumeration:";

            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colour",
            "FormOfStudy",
            "Genre",
            "Season",
            "SmartphoneManufacturer",
            "WeekDay"});
            this.EnumsListBox.Location = new System.Drawing.Point(6, 60);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(182, 212);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.ResultSeasonLabel);
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.GoButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.Location = new System.Drawing.Point(390, 322);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(383, 216);
            this.SeasonGroupBox.TabIndex = 5;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(3, 28);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(110, 17);
            this.SeasonLabel.TabIndex = 0;
            this.SeasonLabel.Text = "Choose season:";

            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(188, 47);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 26);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Autumn"});
            this.SeasonComboBox.Location = new System.Drawing.Point(6, 48);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(176, 24);
            this.SeasonComboBox.TabIndex = 3;
            // 
            // ResultSeasonLabel
            // 
            this.ResultSeasonLabel.AutoSize = true;
            this.ResultSeasonLabel.Location = new System.Drawing.Point(6, 75);
            this.ResultSeasonLabel.Name = "ResultSeasonLabel";
            this.ResultSeasonLabel.Size = new System.Drawing.Size(0, 17);
            this.ResultSeasonLabel.TabIndex = 4;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 575);
            this.Controls.Add(this.EnumsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsTabControl.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.WeekDayGroupBox.ResumeLayout(false);
            this.WeekDayGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumsTabControl;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label EnumerationLabel;
        private System.Windows.Forms.GroupBox WeekDayGroupBox;
        private System.Windows.Forms.Label ResultDayLabel;
        private System.Windows.Forms.Label NameActionLabel;
        private System.Windows.Forms.TextBox WeekDayTextBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label ResultSeasonLabel;
    }
}

