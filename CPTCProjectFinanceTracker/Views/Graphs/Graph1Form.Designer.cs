namespace CPTCProjectFinanceTracker.Views.Graphs
{
    partial class Graph1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            TransactionsByCategoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)TransactionsByCategoryChart).BeginInit();
            SuspendLayout();
            // 
            // TransactionsByCategoryChart
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.AxisX.Title = "Month";
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 15.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.AxisX.Interval = 1; // Ensure each month is displayed
            chartArea1.AxisX.LabelStyle.Format = "MMMM"; // Display full month name
            chartArea1.AxisX.MajorTickMark.Enabled = true; // Enable tick marks
            chartArea1.AxisY.Title = "Amount ($)";
            chartArea1.AxisY.TitleFont = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            chartArea1.Name = "ChartArea1";
            TransactionsByCategoryChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            TransactionsByCategoryChart.Legends.Add(legend1);
            TransactionsByCategoryChart.Location = new Point(12, 12);
            TransactionsByCategoryChart.Name = "TransactionsByCategoryChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Income";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Expense";
            TransactionsByCategoryChart.Series.Add(series1);
            TransactionsByCategoryChart.Series.Add(series2);
            TransactionsByCategoryChart.Size = new Size(1703, 701);
            TransactionsByCategoryChart.TabIndex = 0;
            TransactionsByCategoryChart.Text = "chart1";
            TransactionsByCategoryChart.Click += chart1_Click;
            // 
            // Graph1Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 754);
            Controls.Add(TransactionsByCategoryChart);
            Name = "Graph1Form";
            Text = "Graph1Form";
            ((System.ComponentModel.ISupportInitialize)TransactionsByCategoryChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart TransactionsByCategoryChart;
    }
}