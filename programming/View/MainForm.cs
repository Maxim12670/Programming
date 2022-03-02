using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using programming.Model;

namespace programming
{
    public partial class MainForm : Form
    {
        public enum Colour
        {
            Red,
            Grey,
            Green,
            Yellow,
            Pink,
            Blue,
            Black,
            White
        }

        public enum FormOfStudy
        {
            FullTimeEducation,
            ExtramuralStudies,
            EveningTuition,
            DistanceLearning
        }
        public enum Genre
        {
            Comedy,
            Drama,
            Thriller,
            Action,
            Horror,
            Blockbuster
        }
        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        public enum SmartphoneManufacturer
        {
            Apple,
            Samsung,
            Honor,
            Nokia,
            LG,
            Lenovo,
            Sony
        }
        public enum WeekDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
            String curItem = ValuesListBox.SelectedItem.ToString();
            String enumItem = EnumsListBox.SelectedItem.ToString();
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
            String curItem = EnumsListBox.SelectedItem.ToString();
            switch (curItem)
            {
                case "Colour":
                    ValuesListBox.Items.Clear();
                    foreach (int i in Enum.GetValues(typeof(Colour)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(Colour), i));
                    }
                    break;

                case "FormOfStudy":
                    ValuesListBox.Items.Clear();
                    foreach(int i in Enum.GetValues(typeof(FormOfStudy)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(FormOfStudy), i));
                    }
                    break;

                case "Genre":
                    ValuesListBox.Items.Clear();
                    foreach(int i in Enum.GetValues(typeof(Genre)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(Genre), i));
                    }
                    break;

                case "Season":
                    ValuesListBox.Items.Clear();
                    foreach(int i in Enum.GetValues(typeof(Season)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(Season), i));
                    }
                    break;

                case "SmartphoneManufacturer":
                    ValuesListBox.Items.Clear();
                    foreach(int i in Enum.GetValues(typeof(SmartphoneManufacturer)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(SmartphoneManufacturer), i));
                    }
                    break;

                case "WeekDay":
                    ValuesListBox.Items.Clear();
                    foreach(int i in Enum.GetValues(typeof(WeekDay)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(WeekDay), i));
                    }
                    break;
            }

        }

        private void tabPage_Click(object sender, EventArgs e)
        {

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

        private void SeasonLabel_Click(object sender, EventArgs e)
        {

        }

        private void ValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }

}
