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
            this.ClassesTabControl = new System.Windows.Forms.TabControl();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.ReleaseLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LenghtTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabControl.SuspendLayout();
            this.EnumerationsTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassesTabControl
            // 
            this.ClassesTabControl.Controls.Add(this.EnumerationsTabPage);
            this.ClassesTabControl.Controls.Add(this.tabPage1);
            this.ClassesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesTabControl.Location = new System.Drawing.Point(0, 0);
            this.ClassesTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.ClassesTabControl.Name = "ClassesTabControl";
            this.ClassesTabControl.SelectedIndex = 0;
            this.ClassesTabControl.Size = new System.Drawing.Size(1179, 633);
            this.ClassesTabControl.TabIndex = 0;
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
            this.EnumerationsTabPage.Size = new System.Drawing.Size(1171, 604);
            this.EnumerationsTabPage.TabIndex = 1;
            this.EnumerationsTabPage.Text = "Enums";
            this.EnumerationsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(675, 336);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(488, 260);
            this.SeasonHandleGroupBox.TabIndex = 8;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(181, 44);
            this.GoButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(100, 30);
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
            this.WeekdayGroupBox.Location = new System.Drawing.Point(8, 336);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(659, 260);
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
            this.ParseWeekdayButton.Size = new System.Drawing.Size(100, 30);
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
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(8, 8);
            this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(1155, 329);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MovieGroupBox);
            this.tabPage1.Controls.Add(this.RectanglesGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1171, 604);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.GenreTextBox);
            this.MovieGroupBox.Controls.Add(this.GenreLabel);
            this.MovieGroupBox.Controls.Add(this.NameTextBox);
            this.MovieGroupBox.Controls.Add(this.NameLabel);
            this.MovieGroupBox.Controls.Add(this.FindMovieButton);
            this.MovieGroupBox.Controls.Add(this.RatingLabel);
            this.MovieGroupBox.Controls.Add(this.ReleaseLabel);
            this.MovieGroupBox.Controls.Add(this.DurationLabel);
            this.MovieGroupBox.Controls.Add(this.RatingTextBox);
            this.MovieGroupBox.Controls.Add(this.ReleaseTextBox);
            this.MovieGroupBox.Controls.Add(this.DurationTextBox);
            this.MovieGroupBox.Controls.Add(this.MoviesListBox);
            this.MovieGroupBox.Location = new System.Drawing.Point(572, 8);
            this.MovieGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.MovieGroupBox.Size = new System.Drawing.Size(591, 588);
            this.MovieGroupBox.TabIndex = 1;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movies";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(215, 233);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(199, 22);
            this.GenreTextBox.TabIndex = 11;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(211, 213);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(52, 17);
            this.GenreLabel.TabIndex = 10;
            this.GenreLabel.Text = "Genre:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(215, 185);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(199, 22);
            this.NameTextBox.TabIndex = 9;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(211, 165);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name:";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(215, 544);
            this.FindMovieButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(199, 28);
            this.FindMovieButton.TabIndex = 7;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(211, 117);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(53, 17);
            this.RatingLabel.TabIndex = 6;
            this.RatingLabel.Text = "Rating:";
            // 
            // ReleaseLabel
            // 
            this.ReleaseLabel.AutoSize = true;
            this.ReleaseLabel.Location = new System.Drawing.Point(211, 69);
            this.ReleaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReleaseLabel.Name = "ReleaseLabel";
            this.ReleaseLabel.Size = new System.Drawing.Size(64, 17);
            this.ReleaseLabel.TabIndex = 5;
            this.ReleaseLabel.Text = "Release:";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(211, 21);
            this.DurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(66, 17);
            this.DurationLabel.TabIndex = 4;
            this.DurationLabel.Text = "Duration:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(215, 137);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(199, 22);
            this.RatingTextBox.TabIndex = 3;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // ReleaseTextBox
            // 
            this.ReleaseTextBox.Location = new System.Drawing.Point(215, 89);
            this.ReleaseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReleaseTextBox.Name = "ReleaseTextBox";
            this.ReleaseTextBox.Size = new System.Drawing.Size(199, 22);
            this.ReleaseTextBox.TabIndex = 2;
            this.ReleaseTextBox.TextChanged += new System.EventHandler(this.ReleaseTextBox_TextChanged);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(215, 41);
            this.DurationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(199, 22);
            this.DurationTextBox.TabIndex = 1;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(8, 23);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(199, 548);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.FindRectangleButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LenghtTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LenghtLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(8, 8);
            this.RectanglesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.RectanglesGroupBox.Size = new System.Drawing.Size(556, 588);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(215, 544);
            this.FindRectangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(199, 28);
            this.FindRectangleButton.TabIndex = 7;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(215, 137);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(199, 22);
            this.ColorTextBox.TabIndex = 6;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(215, 89);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(199, 22);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.Location = new System.Drawing.Point(215, 41);
            this.LenghtTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(199, 22);
            this.LenghtTextBox.TabIndex = 4;
            this.LenghtTextBox.TextChanged += new System.EventHandler(this.LenghtTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(211, 117);
            this.ColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(45, 17);
            this.ColorLabel.TabIndex = 3;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(211, 69);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(48, 17);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width:";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(211, 21);
            this.LenghtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(56, 17);
            this.LenghtLabel.TabIndex = 1;
            this.LenghtLabel.Text = "Length:";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.ItemHeight = 16;
            this.RectangleListBox.Location = new System.Drawing.Point(8, 23);
            this.RectangleListBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(199, 548);
            this.RectangleListBox.TabIndex = 0;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 633);
            this.Controls.Add(this.ClassesTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming Demo";
            this.ClassesTabControl.ResumeLayout(false);
            this.EnumerationsTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ClassesTabControl;
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.Button FindRectangleButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LenghtTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.ListBox RectangleListBox;
        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label ReleaseLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox ReleaseTextBox;
        private System.Windows.Forms.Button FindMovieButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
    }
}

