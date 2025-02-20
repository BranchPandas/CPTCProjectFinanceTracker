using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPTCProjectFinanceTracker.Views
{
    public partial class formManageCategories : Form
    {

        private readonly string categoryType;

        public formManageCategories(string categoryType)
        {
            this.categoryType = categoryType;
            InitializeComponent();


            // MessageBox.Show(categoryType); // This was a test to see if the categoryType was being passed correctly

            // Populate the form title with correct name (Expense or Income)
            label1.Text = $"{categoryType} Categories";
            // Populate the listbox with categories from the database

            this.Text = $"Manage {categoryType} Categories";
        }

       
    }
}
