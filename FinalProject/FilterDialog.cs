using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FilterDialog : Form
    {
        public int SelectedYear { get; private set; }
        public int SelectedMonth { get; private set; }

        public FilterDialog(int currentYear, int currentMonth)
        {
            InitializeComponent();

            // Set default values
            dateTimePicker.Value = new DateTime(currentYear, currentMonth, 1);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SelectedYear = dateTimePicker.Value.Year;
            SelectedMonth = dateTimePicker.Value.Month;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
