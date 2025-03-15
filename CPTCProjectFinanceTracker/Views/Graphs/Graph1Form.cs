using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CPTCProjectFinanceTracker.Controllers;
using CPTCProjectFinanceTracker.Database;
using CPTCProjectFinanceTracker.Utilities;
using CPTCProjectFinanceTracker.Models;
using static CPTCProjectFinanceTracker.Utilities.CategoryManager;

namespace CPTCProjectFinanceTracker.Views.Graphs
{
    public partial class Graph1Form : Form
    {

        // Create a new instance of the database context
        private readonly TransactionController _transactionController;
        private readonly UserController _userController;
        private readonly CategoryController _categoryController;


        public Graph1Form()
        {
            InitializeComponent();
            _transactionController = new TransactionController();
            _categoryController = new CategoryController();
            _userController = new UserController();

            // Temporary using account ID 1 - you should replace this with the actual account ID
            int tempAccount = 1;
            var transactions = _transactionController.GetRecentTransactions(tempAccount);
            var categories = _categoryController.GetAll();

            List<MapCategoryToTransaction_ViewModel> sourceData = CategoryManager.MapCategoryToTransaction(transactions, categories);

            if (sourceData == null) return;

            // Aggregate data by month (Using the TransactionDate prop)
            var aggregatedData = sourceData
                .GroupBy(t => new { t.TransactionDate.Year, t.TransactionDate.Month, t.TransactionType })
                .Select(g => new
                {
                    Date = new DateTime(g.Key.Year, g.Key.Month, 1),
                    TransactionType = g.Key.TransactionType,
                    TotalAmount = g.Sum(t => t.TransactionAmount)
                })
                .ToList();

            foreach (var m in aggregatedData)
            {
                // Convert DateOnly to DateTime
                DateTime transactionDateTime = m.Date;

                // Add the Income or Expense series to the chart
                if (m.TransactionType == "Income")
                {
                    TransactionsByCategoryChart.Series["Income"].Points.AddXY(transactionDateTime, m.TotalAmount);
                }
                else
                {
                    TransactionsByCategoryChart.Series["Expense"].Points.AddXY(transactionDateTime, m.TotalAmount);
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
