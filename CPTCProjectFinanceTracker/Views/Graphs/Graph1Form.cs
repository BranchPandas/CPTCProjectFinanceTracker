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

            // Temporary using account ID 1 - you should replace this with the actual account ID
            int tempAccount = 1;
            var transactions = _transactionController.GetRecentTransactions(tempAccount);
            var categories = _categoryController.GetAll();

            List<MapCategoryToTransaction_ViewModel> sourceData = CategoryManager.MapCategoryToTransaction(transactions, categories);


            foreach (MapCategoryToTransaction_ViewModel m in sourceData) { 
                MessageBox.Show(m.ToString());
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
