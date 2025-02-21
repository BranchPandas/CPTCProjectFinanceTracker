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

namespace CPTCProjectFinanceTracker.Views
{
    public partial class formManageCategories : Form
    {

        private readonly TransactionType categoryType;
        private Form parentForm;

        /// <summary>
        /// Constructor for creating this form.
        /// Initializes the form components and renders the category form.
        /// </summary>
        /// <param name="categoryType">The type of category (Expense or Income) to manage.</param>
        /// <param name="parentForm">The Expense or Income Form</param>
        public formManageCategories(TransactionType categoryType, Form parentForm)
        {
            this.categoryType = categoryType;
            this.parentForm = parentForm;
            InitializeComponent();
            renderCategoryForm();
        }

        /// <summary>
        /// Renders the category form by setting the form title and populating the listbox with categories.
        /// </summary>
        private void renderCategoryForm()
        {
            // Populate the form title with correct name (Expense or Income)
            label1.Text = $"{categoryType} Categories";
            // Populate the listbox with categories from the database
            this.Text = $"Manage {categoryType} Categories";


            // Fetch the categories from the database
            CategoryController categoryController = new();
            List<Categories> categories = categoryController.GetAll(categoryType);
            // populate the listbox with the categories
            foreach (Categories category in categories)
            {
                addCategoryToListBox(category);
            }
        }

        /// <summary>
        /// Add a category to the listbox.
        /// The name of the category is displayed in 
        /// the listbox via the DisplayMember property.
        /// </summary>
        /// <param name="item">The category item to be added to the listbox.</param>
        private void addCategoryToListBox(Categories item)
        {
            lstBxCategories.Items.Add(item);
        }



        /// <summary>
        /// Handles the click event for the Upsert Category button.
        /// Validates the input, checks if a category is selected, and either updates the selected category
        /// or creates a new category. Refreshes the listbox and resets the form after the operation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void btnUpsertCategory_Click(object sender, EventArgs e)
        {
            // Make sure the input has value
            // If it does not, show an error message and return
            if (string.IsNullOrWhiteSpace(txtBxCategoryName.Text))
            {
                MessageBox.Show("Please enter a category name or select an existing category in order to edit it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Check the list for a selection.
            // If it is selected, get the category, update the name, and save it.
            // If it is not selected, create a new category, set the name, and save it.

            Categories? selectedCategory = (Categories?)lstBxCategories.SelectedItem;
            CategoryController categoryController = new();

            if (selectedCategory != null)
            {

                // Update the actual Category in DB and instance
                selectedCategory.CategoryName = txtBxCategoryName.Text;
                categoryController.Update(selectedCategory);

                // Refresh the ListBox to reflect the updated category name
                int selectedIndex = lstBxCategories.SelectedIndex;
                lstBxCategories.Items[selectedIndex] = selectedCategory;

                // Update the item in the parentForm dropdown

            }
            else
            {


                // Create a new category
                Categories category = new()
                {
                    CategoryType = TransactionType.Expense.ToString(),
                    CategoryName = txtBxCategoryName.Text
                };

                categoryController.Add(category);

                // Add the category to the listbox
                addCategoryToListBox(category);

                // Add Category to parent form dropdown
            }

            resetForm();
        }

        /// <summary>
        /// Handles the event when the selected index of the listbox changes.
        /// Updates the input field with the selected category's name, changes the button text to "Update Category",
        /// focuses the text input, and enables the delete button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void lstBxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {



            // Get the selected category
            Categories? category = (Categories?)lstBxCategories.SelectedItem;

            if (category != null)
            {
                // Update the input with value
                txtBxCategoryName.Text = category.CategoryName.ToString();
                // Update the Button text to say update
                btnUpsertCategory.Text = "Update Category";

                // Focus the text input
                txtBxCategoryName.Focus();

                // Enable the delete button
                btnDeleteCategory.Enabled = true;

            }



        }

        /// <summary>
        /// Handles the click event for the Delete Category button.
        /// Removes the selected category from the database and the listbox.
        /// Resets the form after the operation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            // Get the selected item
            Categories? category = (Categories?)lstBxCategories.SelectedItem;

            if (category != null)
            {
                // Remove item from database
                CategoryController categoryController = new();
                categoryController.Delete(category);
                // Remove item from UI
                lstBxCategories.Items.Remove(category);

                resetForm();
            }
        }


        /// <summary>
        /// Resets the form to its default state.
        /// Clears the input field, sets the button text to "Create Category",
        /// disables the delete button, and deselects any selected item in the listbox.
        /// </summary>
        private void resetForm()
        {
            // Clear input / reset form
            txtBxCategoryName.Text = String.Empty;
            btnUpsertCategory.Text = "Create Category";
            // Disable the delete button
            btnDeleteCategory.Enabled = false;

            lstBxCategories.SelectedItem = null;
        }
    }
}
