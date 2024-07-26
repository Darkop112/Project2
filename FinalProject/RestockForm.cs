using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmRestock : Form
    {
        public Dictionary<string, int> RestockItems { get; private set; }

        private Dictionary<string, int> clickCounts;

        public frmRestock()
        {
            InitializeComponent();
            RestockItems = new Dictionary<string, int>();
            clickCounts = new Dictionary<string, int>
            {
                { "Apple", 0 },
                { "Banana", 0 },
                { "Grapes", 0 },
                { "Mango", 0 },
                { "Pineapple", 0 },
                { "Orange", 0 },
                { "Strawberry", 0 },
                { "Sugar Apple", 0 },
                { "Watermelon", 0 }
            };

            // Bind button click events
            btnAddApple.Click += (s, e) => IncrementCount("Apple");
            btnAddBanana.Click += (s, e) => IncrementCount("Banana");
            btnAddGrapes.Click += (s, e) => IncrementCount("Grapes");
            btnAddMango.Click += (s, e) => IncrementCount("Mango");
            btnAddPineapple.Click += (s, e) => IncrementCount("Pineapple");
            btnAddOrange.Click += (s, e) => IncrementCount("Orange");
            btnAddStrawberry.Click += (s, e) => IncrementCount("Strawberry");
            btnAddSugarApple.Click += (s, e) => IncrementCount("Sugar Apple");
            btnAddWatermelon.Click += (s, e) => IncrementCount("Watermelon");

            btnMinusApple.Click += (s, e) => IncrementCount2("Apple");
            btnMinusBanana.Click += (s, e) => IncrementCount2("Banana");
            btnMinusGrapes.Click += (s, e) => IncrementCount2("Grapes");
            btnMinusMango.Click += (s, e) => IncrementCount2("Mango");
            btnMinusPineapple.Click += (s, e) => IncrementCount2("Pineapple");
            btnMinusOrange.Click += (s, e) => IncrementCount2("Orange");
            btnMinusStrawberry.Click += (s, e) => IncrementCount2("Strawberry");
            btnMinusSugarApple.Click += (s, e) => IncrementCount2("Sugar Apple");
            btnMinusWatermelon.Click += (s, e) => IncrementCount2("Watermelon");

            // Apply button click event
            btnApply.Click += btnApply_Click;
        }

        private void IncrementCount(string fruitName)
        {
            clickCounts[fruitName]++;
            UpdateLabel(fruitName);
        }
        private void IncrementCount2(string fruitName)
        {
            if (clickCounts[fruitName] > 0)
            {
                clickCounts[fruitName]--;
            }
            UpdateLabel(fruitName);
        }

        private void UpdateLabel(string fruitName)
        {
            var labelName = $"lbl{fruitName.Replace(" ", "")}Count";
            var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;
            if (label != null)
            {
                label.Text = clickCounts[fruitName].ToString();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            RestockItems = new Dictionary<string, int>(clickCounts);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmRestock_Load(object sender, EventArgs e)
        {
            // Initialize any additional components if necessary
        }

        private void btnAddApple_Click(object sender, EventArgs e)
        {

        }
    }
}
