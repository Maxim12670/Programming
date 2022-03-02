using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        //public enum Colour
        //{
        //    Red,
        //    Grey,
        //    Green,
        //    Yellow,
        //    Pink,
        //    Blue,
        //    Black,
        //    White
        //}

        //public enum FormOfStudy
        //{
        //    FullTimeEducation,
        //    ExtramuralStudies,
        //    EveningTuition,
        //    DistanceLearning
        //}
        //public enum Genre
        //{
        //    Comedy,
        //    Drama,
        //    Thriller,
        //    Action,
        //    Horror,
        //    Blockbuster
        //}
        //public enum Season
        //{
        //    Winter,
        //    Spring,
        //    Summer,
        //    Autumn
        //}
        //public enum SmartphoneManufacturer
        //{
        //    Apple,
        //    Samsung,
        //    Honor,
        //    Nokia,
        //    LG,
        //    Lenovo,
        //    Sony
        //}
        //public enum WeekDay
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
        public MainForm()
        {
            InitializeComponent();
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string curItem = ValuesListBox.SelectedItem.ToString();
            string enumItem = EnumsListBox.SelectedItem.ToString();
            switch (enumItem)
            {
                case "Colour":
                foreach(int i in Enum.GetValues(typeof(Colour)))
                {
                    if(Enum.GetName(typeof(Colour),i) == curItem)
                        {
                            IntValueTextBox.Text = Convert.ToString(i+1);
                        }
                    }
                    break;

                case "FormOfStudy":
                    foreach (int i in Enum.GetValues(typeof(FormOfStudy)))
                    {
                        if (Enum.GetName(typeof(FormOfStudy), i) == curItem)
                        {
                            IntValueTextBox.Text = Convert.ToString(i + 1);
                        }
                    }
                    break;

                case "Genre":
                    foreach (int i in Enum.GetValues(typeof(Genre)))
                    {
                        if (Enum.GetName(typeof(Genre), i) == curItem)
                        {
                            IntValueTextBox.Text = Convert.ToString(i + 1);
                        }
                    }
                    break;

                case "Season":
                    foreach (int i in Enum.GetValues(typeof(Season)))
                    {
                        if (Enum.GetName(typeof(Season), i) == curItem)
                        {
                            IntValueTextBox.Text = Convert.ToString(i + 1);
                        }
                    }
                    break;

                case "SmartphoneManufacturer":
                    foreach (int i in Enum.GetValues(typeof(SmartphoneManufacturer)))
                    {
                        if (Enum.GetName(typeof(SmartphoneManufacturer), i) == curItem)
                        {
                            IntValueTextBox.Text = Convert.ToString(i + 1);
                        }
                    }
                    break;

                case "WeekDay":
                    foreach (int i in Enum.GetValues(typeof(WeekDay)))
                    {
                        if (Enum.GetName(typeof(WeekDay), i) == curItem)
                        {
                            IntValueTextBox.Text = Convert.ToString(i + 1);
                        }
                    }
                    break;
            }
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Clear();
            switch (EnumsListBox.SelectedItem)
            {
                case View.Enums.Colour:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colour));
                    break;

                case View.Enums.FormOfStudy:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(FormOfStudy));
                    break;

                case View.Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;

                case View.Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;

                case View.Enums.SmartphoneManufacturer:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(SmartphoneManufacturer));
                    break;

                case View.Enums.WeekDay:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(WeekDay));
                    break;
            }
        }
        private void ParseButton_Click(object sender, EventArgs e)
        {
            string weekDay = WeekDayTextBox.Text;
            WeekDay value;
            
            if (Enum.TryParse(weekDay, out value))
            {
                ResultDayLabel.Text = $"Это день недели ({value} = {(int)value + 1})";
            }
            else
            {
                ResultDayLabel.Text = "Нет такого дня недели";
            }
        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            string season = SeasonComboBox.SelectedItem.ToString();
            switch (season)
            {
                case "Winter":
                    GoButton.BackColor = Color.Transparent;
                    ResultSeasonLabel.Text = "Брррр, холодно!";
                    break;

                case "Spring":
                    GoButton.BackColor = Color.Orange;
                    break;

                case "Summer":
                    GoButton.BackColor = Color.Transparent;
                    ResultSeasonLabel.Text = "Урааа! Солнце!";
                    break;

                case "Autumn":
                    GoButton.BackColor = Color.Yellow;
                    break;
            }
        }
    }
}
