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
using Programming.Model.Classes;
using Programming.Model.Enums;
namespace Programming.View
{

    /// <summary>
    /// Представляет реализацию по представлению перечислений.
    /// </summary>
    public partial class AllEnumerationsControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="AllEnumerationsControl"/>.
        /// </summary>
        public AllEnumerationsControl()
        {
            InitializeComponent();

            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexItem = ValuesListBox.SelectedItem;
            IntValueTextBox.Text = ((int)indexItem).ToString();
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
