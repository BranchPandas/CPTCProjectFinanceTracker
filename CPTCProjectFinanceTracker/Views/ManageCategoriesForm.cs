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

        public formManageCategories(TransactionType categoryType)
        {
            this.categoryType = categoryType;
            InitializeComponent();
            renderCategoryForm();



        }

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
        /// Add a category to the listbox
        /// The name of the category is displayed in 
        /// the listbox via the DisplayMember property
        /// </summary>
        /// <param name="item"></param>
        private void addCategoryToListBox(Categories item)
        {
            lstBxCategories.Items.Add(item);
        }



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

            if (selectedCategory != null) {

                // Update the actual Category in DB and instance
                selectedCategory.CategoryName = txtBxCategoryName.Text;
                categoryController.Update(selectedCategory);

                // Refresh the ListBox to reflect the updated category name
                int selectedIndex = lstBxCategories.SelectedIndex;
                lstBxCategories.Items[selectedIndex] = selectedCategory;

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
            }
        }

        private void lstBxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

       

            // Get the selected category
           Categories? category =  (Categories?)lstBxCategories.SelectedItem;

            if (category != null)
            {
                // Update the input with value
                txtBxCategoryName.Text = category.CategoryName.ToString();
                // Update the Button text to say update
                btnUpsertCategory.Text = "Update Category";

                // Focus the text input
                txtBxCategoryName.Focus();
            }
          
            

        }
    }
}
