using CPTCProjectFinanceTracker;
using CPTCProjectFinanceTracker.Controllers;
using CPTCProjectFinanceTracker.Models;
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

        public AddExpensesForm(HomeScreen homeScreen)
        {
            InitializeComponent();
            _controller = new TransactionController();
            _homeScreen = homeScreen;

            // Add the Expense Categories to the ComboBox
            CategoryController categoryController = new();
            List<Categories> categories = categoryController.GetAll(TransactionType.Expense);
            foreach (Categories category in categories)
            {
                cmboBxExpenseCategory.Items.Add(category);
            }
        }

        /// <summary>
        /// Removes a category item from the expense category ComboBox.
        /// </summary>
        /// <param name="category">The category to be removed.</param>
        public void RemoveCategoryItem(Categories category)
        {
            // Find the category by its ID
            Categories? itemToRemove = cmboBxExpenseCategory.Items
                .Cast<Categories>()
                .FirstOrDefault(c => c.CategoryId == category.CategoryId);

            // Remove the category if found
            if (itemToRemove != null)
            {
                cmboBxExpenseCategory.Items.Remove(itemToRemove);
            }
        }

        /// <summary>
        /// Updates an existing category item in the expense category ComboBox.
        /// Finds the category by its ID and updates its details.
        /// </summary>
        /// <param name="category">The category to be updated.</param>
        public void UpdateCategoryItem(Categories category)
        {
            // Get Category from the list
            Categories? itemToUpdate = cmboBxExpenseCategory.Items
                .Cast<Categories>()
                .FirstOrDefault(c => c.CategoryId == category.CategoryId);

            if (itemToUpdate != null)
            {
                int index = cmboBxExpenseCategory.Items.IndexOf(itemToUpdate);
                cmboBxExpenseCategory.Items[index] = category;
            }
            // refresh listbox
            cmboBxExpenseCategory.Refresh();
        }

        /// <summary>
        /// Adds a new category item to the expense category ComboBox.
        /// Checks if the category already exists in the ComboBox before adding.
        /// </summary>
        /// <param name="category">The category to be added.</param>
        public void AddCategoryItem(Categories category)
        {
            if (!cmboBxExpenseCategory.Items.Cast<Categories>().Any(c => c.CategoryId == category.CategoryId))
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
                    CategoryId = 1, // TODO: Get category ID from user selection
                    TransactionAmount = decimal.Parse(txtbxExpenseAmount.Text),
                    TransactionType = "Expense",
                    TransactionDescription = txtbxExpenseDescription.Text,
                    TransactionDate = DateOnly.FromDateTime(DateTime.Now)
                };

                // Let controller handle the transaction
                _controller.SaveTransaction(transaction);
                ResetExpenseForm();
                Confirm();
                _homeScreen.LoadAccountBalance();
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
            Views.formManageCategories manageCategoriesForm = new Views.formManageCategories(TransactionType.Expense, this);
            manageCategoriesForm.Show();
        }
    }
}
