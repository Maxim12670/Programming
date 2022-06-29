
namespace Programming.View.Controls
{
    partial class MoviesControl
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
            this.SuspendLayout();
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(211, 214);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(199, 22);
            this.GenreTextBox.TabIndex = 23;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(207, 194);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(52, 17);
            this.GenreLabel.TabIndex = 22;
            this.GenreLabel.Text = "Genre:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(211, 166);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(199, 22);
            this.NameTextBox.TabIndex = 21;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(207, 146);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 20;
            this.NameLabel.Text = "Name:";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(211, 525);
            this.FindMovieButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(199, 28);
            this.FindMovieButton.TabIndex = 19;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(207, 98);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(53, 17);
            this.RatingLabel.TabIndex = 18;
            this.RatingLabel.Text = "Rating:";
            // 
            // ReleaseLabel
            // 
            this.ReleaseLabel.AutoSize = true;
            this.ReleaseLabel.Location = new System.Drawing.Point(207, 50);
            this.ReleaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReleaseLabel.Name = "ReleaseLabel";
            this.ReleaseLabel.Size = new System.Drawing.Size(64, 17);
            this.ReleaseLabel.TabIndex = 17;
            this.ReleaseLabel.Text = "Release:";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(207, 2);
            this.DurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(66, 17);
            this.DurationLabel.TabIndex = 16;
            this.DurationLabel.Text = "Duration:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(211, 118);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(199, 22);
            this.RatingTextBox.TabIndex = 15;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // ReleaseTextBox
            // 
            this.ReleaseTextBox.Location = new System.Drawing.Point(211, 70);
            this.ReleaseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReleaseTextBox.Name = "ReleaseTextBox";
            this.ReleaseTextBox.Size = new System.Drawing.Size(199, 22);
            this.ReleaseTextBox.TabIndex = 14;
            this.ReleaseTextBox.TextChanged += new System.EventHandler(this.ReleaseTextBox_TextChanged);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(211, 22);
            this.DurationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(199, 22);
            this.DurationTextBox.TabIndex = 13;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(4, 4);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(199, 548);
            this.MoviesListBox.TabIndex = 12;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FindMovieButton);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.ReleaseLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.ReleaseTextBox);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.MoviesListBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(422, 562);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button FindMovieButton;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label ReleaseLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox ReleaseTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
    }
}
