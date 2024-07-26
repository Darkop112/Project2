using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YourNamespace
{
    public partial class ReportAndAnalysisForm : Form
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            this.reportChart = new Chart();

            this.salesTrendButton = new Button();
            this.inventoryAnalysisButton = new Button();
            this.profitAnalysisButton = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            this.SuspendLayout();

            // 
            // salesTrendButton
            // 
            this.salesTrendButton.Location = new System.Drawing.Point(12, 12);
            this.salesTrendButton.Name = "salesTrendButton";
            this.salesTrendButton.Size = new System.Drawing.Size(100, 23);
            this.salesTrendButton.TabIndex = 0;
            this.salesTrendButton.Text = "Sales Trend";
            this.salesTrendButton.UseVisualStyleBackColor = true;

            // 
            // inventoryAnalysisButton
            // 
            this.inventoryAnalysisButton.Location = new System.Drawing.Point(118, 12);
            this.inventoryAnalysisButton.Name = "inventoryAnalysisButton";
            this.inventoryAnalysisButton.Size = new System.Drawing.Size(120, 23);
            this.inventoryAnalysisButton.TabIndex = 1;
            this.inventoryAnalysisButton.Text = "Inventory Analysis";
            this.inventoryAnalysisButton.UseVisualStyleBackColor = true;

            // 
            // profitAnalysisButton
            // 
            this.profitAnalysisButton.Location = new System.Drawing.Point(244, 12);
            this.profitAnalysisButton.Name = "profitAnalysisButton";
            this.profitAnalysisButton.Size = new System.Drawing.Size(100, 23);
            this.profitAnalysisButton.TabIndex = 2;
            this.profitAnalysisButton.Text = "Profit Analysis";
            this.profitAnalysisButton.UseVisualStyleBackColor = true;

            // 
            // reportChart
            // 
            chartArea1.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.reportChart.Legends.Add(legend1);
            this.reportChart.Location = new System.Drawing.Point(12, 50);
            this.reportChart.Name = "reportChart";
            this.reportChart.Size = new System.Drawing.Size(776, 388);
            this.reportChart.TabIndex = 3;
            this.reportChart.Text = "chart1";

            // 
            // ReportAndAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportChart);
            this.Controls.Add(this.profitAnalysisButton);
            this.Controls.Add(this.inventoryAnalysisButton);
            this.Controls.Add(this.salesTrendButton);
            this.Name = "ReportAndAnalysisForm";
            this.Text = "Report and Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
