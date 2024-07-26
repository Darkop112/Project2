namespace FinalProject
{
    partial class SalesHistory
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewSalesHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewSalesHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalesHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSalesHistory
            // 
            dataGridViewSalesHistory.BackgroundColor = Color.White;
            dataGridViewSalesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSalesHistory.Location = new Point(39, 61);
            dataGridViewSalesHistory.Name = "dataGridViewSalesHistory";
            dataGridViewSalesHistory.RowHeadersWidth = 51;
            dataGridViewSalesHistory.RowTemplate.Height = 29;
            dataGridViewSalesHistory.Size = new Size(931, 474);
            dataGridViewSalesHistory.TabIndex = 0;
            // 
            // SalesHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(996, 547);
            ControlBox = false;
            Controls.Add(dataGridViewSalesHistory);
            Name = "SalesHistory";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalesHistory).EndInit();
            ResumeLayout(false);
        }
    }
}
