using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject
{
    partial class ReportAndAnalysisForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button salesTrendButton;
        private Button inventoryAnalysisButton;
        private Button profitAnalysisButton;
        private Chart reportChart;

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
            this.salesTrendButton = new System.Windows.Forms.Button();
            this.inventoryAnalysisButton = new System.Windows.Forms.Button();
            this.profitAnalysisButton = new System.Windows.Forms.Button();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            this.SuspendLayout();

            // salesTrendButton
            this.salesTrendButton.Location = new System.Drawing.Point(12, 12);
            this.salesTrendButton.Name = "salesTrendButton";
            this.salesTrendButton.Size = new System.Drawing.Size(75, 23);
            this.salesTrendButton.TabIndex = 0;
            this.salesTrendButton.Text = "Sales Trend";
            this.salesTrendButton.UseVisualStyleBackColor = true;

            // inventoryAnalysisButton
            this.inventoryAnalysisButton.Location = new System.Drawing.Point(93, 12);
            this.inventoryAnalysisButton.Name = "inventoryAnalysisButton";
            this.inventoryAnalysisButton.Size = new System.Drawing.Size(125, 23);
            this.inventoryAnalysisButton.TabIndex = 1;
            this.inventoryAnalysisButton.Text = "Inventory Analysis";
            this.inventoryAnalysisButton.UseVisualStyleBackColor = true;

            // profitAnalysisButton
            this.profitAnalysisButton.Location = new System.Drawing.Point(224, 12);
            this.profitAnalysisButton.Name = "profitAnalysisButton";
            this.profitAnalysisButton.Size = new System.Drawing.Size(100, 23);
            this.profitAnalysisButton.TabIndex = 2;
            this.profitAnalysisButton.Text = "Profit Analysis";
            this.profitAnalysisButton.UseVisualStyleBackColor = true;

            // reportChart
            this.reportChart.Location = new System.Drawing.Point(12, 41);
            this.reportChart.Name = "reportChart";
            this.reportChart.Size = new System.Drawing.Size(776, 397);
            this.reportChart.TabIndex = 3;
            this.reportChart.Text = "chart1";

            // ReportAndAnalysisForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportChart);
            this.Controls.Add(this.profitAnalysisButton);
            this.Controls.Add(this.inventoryAnalysisButton);
            this.Controls.Add(this.salesTrendButton);
            this.Name = "ReportAndAnalysisForm";
            this.Text = "Report And Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            this.ResumeLayout(false);
        }

     
    }
}
