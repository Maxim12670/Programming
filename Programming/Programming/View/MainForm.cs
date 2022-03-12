using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.View;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            EnumsListBox.SelectedIndex = 0;
        }
        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Clear();
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Colors:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
                    break;

                case Enums.EducationForm:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;

                case Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;

                case Enums.Manufacture:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufacture));
                    break;

                case Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;

                case Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexItem = ValuesListBox.SelectedItem;
            IntValueTextBox.Text = ((int)indexItem).ToString();
        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            var season = SeasonComboBox.SelectedItem;
            switch (season)
            {
                case Season.Winter:
                    GoButton.BackColor = Color.Transparent;
                    MessageBox.Show("Бррр! Холодно!");
                    break;

                case Season.Spring:
                    GoButton.BackColor = Color.Orange;
                    break;

                case Season.Summer:
                    GoButton.BackColor = Color.Transparent;
                    MessageBox.Show("Ура! Солнце!");
                    break;

                case Season.Autumn:
                    GoButton.BackColor = Color.Yellow;
                    break;
            }
        }
        private void ParseWeekdayButton_Click(object sender, EventArgs e)
        {
            var weekdayText = WeekdayTextBox.Text;
            Weekday weekday;
            if (Enum.TryParse(weekdayText, out weekday))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({weekday} - {(int)weekday})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого дня недели!";
            }
        }
    }
}
