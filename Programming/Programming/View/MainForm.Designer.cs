using System;

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
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.seasonControl1 = new Programming.View.SeasonControl();
            this.weekdayControl1 = new Programming.View.WeekdayControl();
            this.allEnumerationsControl1 = new Programming.View.AllEnumerationsControl();
            this.moviesControl1 = new Programming.View.MoviesControl();
            this.rectanglesControl1 = new Programming.View.RectanglesControl();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.ClassesTabControl.SuspendLayout();
            this.EnumerationsTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassesTabControl
            // 
            this.ClassesTabControl.Controls.Add(this.EnumerationsTabPage);
            this.ClassesTabControl.Controls.Add(this.EnumsTabPage);
            this.ClassesTabControl.Controls.Add(this.RectanglesTabPage);
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
            this.SeasonHandleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandleGroupBox.Controls.Add(this.seasonControl1);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(675, 336);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(488, 260);
            this.SeasonHandleGroupBox.TabIndex = 8;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekdayGroupBox.Controls.Add(this.weekdayControl1);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(8, 336);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(659, 260);
            this.WeekdayGroupBox.TabIndex = 7;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationsGroupBox.Controls.Add(this.allEnumerationsControl1);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(8, 8);
            this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(1155, 329);
            this.EnumerationsGroupBox.TabIndex = 6;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.MovieGroupBox);
            this.EnumsTabPage.Controls.Add(this.RectanglesGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.EnumsTabPage.Size = new System.Drawing.Size(1171, 604);
            this.EnumsTabPage.TabIndex = 2;
            this.EnumsTabPage.Text = "Classes";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.moviesControl1);
            this.MovieGroupBox.Location = new System.Drawing.Point(572, 8);
            this.MovieGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.MovieGroupBox.Size = new System.Drawing.Size(591, 588);
            this.MovieGroupBox.TabIndex = 1;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movies";
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.rectanglesControl1);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(8, 8);
            this.RectanglesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.RectanglesGroupBox.Size = new System.Drawing.Size(556, 588);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 25);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(1171, 604);
            this.RectanglesTabPage.TabIndex = 3;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // seasonControl1
            // 
            this.seasonControl1.Location = new System.Drawing.Point(7, 22);
            this.seasonControl1.Name = "seasonControl1";
            this.seasonControl1.Size = new System.Drawing.Size(474, 238);
            this.seasonControl1.TabIndex = 0;
            // 
            // weekdayControl1
            // 
            this.weekdayControl1.Location = new System.Drawing.Point(0, 22);
            this.weekdayControl1.Name = "weekdayControl1";
            this.weekdayControl1.Size = new System.Drawing.Size(652, 231);
            this.weekdayControl1.TabIndex = 0;
            // 
            // allEnumerationsControl1
            // 
            this.allEnumerationsControl1.Location = new System.Drawing.Point(0, 18);
            this.allEnumerationsControl1.Name = "allEnumerationsControl1";
            this.allEnumerationsControl1.Size = new System.Drawing.Size(1148, 311);
            this.allEnumerationsControl1.TabIndex = 0;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(7, 19);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(422, 562);
            this.moviesControl1.TabIndex = 0;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(7, 22);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(542, 559);
            this.rectanglesControl1.TabIndex = 0;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(1165, 598);
            this.rectanglesCollisionControl1.TabIndex = 0;
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
            this.WeekdayGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.MovieGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ClassesTabControl;
        private System.Windows.Forms.TabPage EnumerationsTabPage;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private SeasonControl seasonControl1;
        private WeekdayControl weekdayControl1;
        private RectanglesControl rectanglesControl1;
        private MoviesControl moviesControl1;
        private AllEnumerationsControl allEnumerationsControl1;
    }
}

