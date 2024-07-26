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
            ChartArea chartArea1 = new ChartArea();
            ChartArea chartArea2 = new ChartArea();
            ChartArea chartArea3 = new ChartArea();
            ChartArea chartArea4 = new ChartArea();
            ChartArea chartArea5 = new ChartArea();
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
            salesTrendButton.Location = new Point(15, 15);
            salesTrendButton.Margin = new Padding(4);
            salesTrendButton.Name = "salesTrendButton";
            salesTrendButton.Size = new Size(172, 26);
            salesTrendButton.TabIndex = 0;
            salesTrendButton.Text = "Sales Trend Analysis";
            salesTrendButton.UseVisualStyleBackColor = true;
            // 
            // inventoryAnalysisButton
            // 
            inventoryAnalysisButton.Location = new Point(207, 15);
            inventoryAnalysisButton.Margin = new Padding(4);
            inventoryAnalysisButton.Name = "inventoryAnalysisButton";
            inventoryAnalysisButton.Size = new Size(188, 26);
            inventoryAnalysisButton.TabIndex = 1;
            inventoryAnalysisButton.Text = "Inventory Analysis";
            inventoryAnalysisButton.UseVisualStyleBackColor = true;
            // 
            // profitAnalysisButton
            // 
            profitAnalysisButton.Location = new Point(410, 15);
            profitAnalysisButton.Margin = new Padding(4);
            profitAnalysisButton.Name = "profitAnalysisButton";
            profitAnalysisButton.Size = new Size(179, 26);
            profitAnalysisButton.TabIndex = 2;
            profitAnalysisButton.Text = "Profit Analysis";
            profitAnalysisButton.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(597, 15);
            filterButton.Margin = new Padding(4);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(222, 26);
            filterButton.TabIndex = 3;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            // 
            // reportChart
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea3.Name = "ChartArea3";
            chartArea4.Name = "ChartArea4";
            chartArea5.Name = "ChartArea5";
            reportChart.ChartAreas.Add(chartArea1);
            reportChart.ChartAreas.Add(chartArea2);
            reportChart.ChartAreas.Add(chartArea3);
            reportChart.ChartAreas.Add(chartArea4);
            reportChart.ChartAreas.Add(chartArea5);
            reportChart.Location = new Point(2, 101);
            reportChart.Margin = new Padding(3, 2, 3, 2);
            reportChart.Name = "reportChart";
            reportChart.Size = new Size(1702, 662);
            reportChart.TabIndex = 0;
            // 
            // ReportAndAnalysisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 388);
            ControlBox = false;
            Controls.Add(reportChart);
            Controls.Add(filterButton);
            Controls.Add(profitAnalysisButton);
            Controls.Add(inventoryAnalysisButton);
            Controls.Add(salesTrendButton);
            Margin = new Padding(4);
            Name = "ReportAndAnalysisForm";
            ((ISupportInitialize)reportChart).EndInit();
            ResumeLayout(false);
        }
    }
}
