using CPTCProjectFinanceTracker;
using CPTCProjectFinanceTracker.Controllers;
using CPTCProjectFinanceTracker.Models;
using CPTCProjectFinanceTracker.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPTCProjectFinanceTracker
{
    public partial class AddExpensesForm : Form
    {

        private readonly TransactionController _controller;
        private readonly HomeScreen _homeScreen;
        public CategoryManager _categoryManager;

        public AddExpensesForm(HomeScreen homeScreen)
        {
            InitializeComponent();
            _controller = new TransactionController();
            _homeScreen = homeScreen;
            _categoryManager = new CategoryManager(cmboBxExpenseCategory);

            // Add the Expense Categories to the ComboBox
            CategoryController categoryController = new();
            List<Categories> categories = categoryController.GetAll(TransactionType.Expense);
            foreach (Categories category in categories)
            {
                cmboBxExpenseCategory.Items.Add(category);
            }
        }


      


        /// <summary>
        /// Handles the click event for the Add Expense Transaction button.
        /// Creates a new transaction object, populates it with data from the form,
        /// and saves it using the TransactionController. Clears the form fields
        /// and shows a confirmation message upon successful save.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void btnAddExpenseTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                var transaction = new Transactions
                {
                    // TransactionId = automatically generated Id from database
                    AccountId = 1, // TODO: Get account ID from user selection
                    CategoryId = ((Categories)cmboBxExpenseCategory.SelectedItem!).CategoryId,
                    TransactionAmount = decimal.Parse(txtbxExpenseAmount.Text),
                    TransactionType = "Expense",
                    TransactionDescription = txtbxExpenseDescription.Text,
                    TransactionDate = DateOnly.FromDateTime(dtpExpenseDate.Value)
                };

                // Let controller handle the transaction
                _controller.SaveTransaction(transaction);
                ResetExpenseForm();
                Confirm();
                //_homeScreen.LoadAccountBalance();
                _homeScreen.LoadRecentTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Resets the expense form fields to their default state.
        /// Clears the text boxes for expense name, amount, and description.
        /// </summary>
        private void ResetExpenseForm()
        {
            txtbxExpenseAmount.Clear();
            txtbxExpenseDescription.Clear();
        }

        private void Confirm()
        {
            MessageBox.Show("Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            // Open the ManageCategoriesForm
            Views.FormManageCategories manageCategoriesForm = new Views.FormManageCategories(TransactionType.Expense, this);
            manageCategoriesForm.Show();
        }
    }
}
