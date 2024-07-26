using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FilterForm : Form
    {
        public int SelectedYear { get; private set; }
        public int SelectedMonth { get; private set; }

        public FilterForm(int currentYear, int currentMonth)
        {
            InitializeComponent();
            SelectedYear = currentYear;
            SelectedMonth = currentMonth;

            numericUpDownYear.Value = currentYear;
            numericUpDownMonth.Value = currentMonth;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SelectedYear = (int)numericUpDownYear.Value;
            SelectedMonth = (int)numericUpDownMonth.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
