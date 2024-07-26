using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject
{
    partial class ReportAndAnalysisForm
    {
        private IContainer components = null;
        private Button salesTrendButton;
        private Button inventoryAnalysisButton;
        private Button profitAnalysisButton;
        private Button filterButton;
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
            salesTrendButton = new Button();
            inventoryAnalysisButton = new Button();
            profitAnalysisButton = new Button();
            filterButton = new Button();
            reportChart = new Chart();
            ((ISupportInitialize)reportChart).BeginInit();
            SuspendLayout();
            // 
            // salesTrendButton
            // 
            salesTrendButton.Location = new Point(12, 15);
            salesTrendButton.Margin = new Padding(3, 4, 3, 4);
            salesTrendButton.Name = "salesTrendButton";
            salesTrendButton.Size = new Size(120, 30);
            salesTrendButton.TabIndex = 0;
            salesTrendButton.Text = "Sales Trend";
            salesTrendButton.UseVisualStyleBackColor = true;
            // 
            // inventoryAnalysisButton
            // 
            inventoryAnalysisButton.Location = new Point(138, 15);
            inventoryAnalysisButton.Margin = new Padding(3, 4, 3, 4);
            inventoryAnalysisButton.Name = "inventoryAnalysisButton";
            inventoryAnalysisButton.Size = new Size(150, 30);
            inventoryAnalysisButton.TabIndex = 1;
            inventoryAnalysisButton.Text = "Inventory Analysis";
            inventoryAnalysisButton.UseVisualStyleBackColor = true;
            // 
            // profitAnalysisButton
            // 
            profitAnalysisButton.Location = new Point(294, 15);
            profitAnalysisButton.Margin = new Padding(3, 4, 3, 4);
            profitAnalysisButton.Name = "profitAnalysisButton";
            profitAnalysisButton.Size = new Size(120, 30);
            profitAnalysisButton.TabIndex = 2;
            profitAnalysisButton.Text = "Profit Analysis";
            profitAnalysisButton.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(420, 15);
            filterButton.Margin = new Padding(3, 4, 3, 4);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(100, 30);
            filterButton.TabIndex = 3;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            // 
            // reportChart
            // 
            reportChart.Location = new Point(12, 60);
            reportChart.Margin = new Padding(3, 4, 3, 4);
            reportChart.Name = "reportChart";
            reportChart.Size = new Size(960, 450);
            reportChart.TabIndex = 4;
            reportChart.Text = "chart1";
            // 
            // ReportAndAnalysisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 520);
            ControlBox = false;
            Controls.Add(reportChart);
            Controls.Add(filterButton);
            Controls.Add(profitAnalysisButton);
            Controls.Add(inventoryAnalysisButton);
            Controls.Add(salesTrendButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportAndAnalysisForm";
            ((ISupportInitialize)reportChart).EndInit();
            ResumeLayout(false);
        }
    }
}
