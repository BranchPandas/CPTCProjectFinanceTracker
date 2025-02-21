using CPTCProjectFinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Utilites
{
    public class CategoryManager
    {
        private ComboBox _comboBox;

        public CategoryManager(ComboBox comboBox)
        {
            _comboBox = comboBox;
        }

        /// <summary>
        /// Removes a category item from the ComboBox.
        /// </summary>
        /// <param name="category">The category to be removed.</param>
        public void RemoveCategoryItem(Categories category)
        {
            // Find the category by its ID
            Categories? itemToRemove = _comboBox.Items
                .Cast<Categories>()
                .FirstOrDefault(c => c.CategoryId == category.CategoryId);

            // Remove the category if found
            if (itemToRemove != null)
            {
                _comboBox.Items.Remove(itemToRemove);
            }
        }

        /// <summary>
        /// Updates an existing category item in the ComboBox.
        /// Finds the category by its ID and updates its details.
        /// </summary>
        /// <param name="category">The category to be updated.</param>
        public void UpdateCategoryItem(Categories category)
        {
            // Get Category from the list
            Categories? itemToUpdate = _comboBox.Items
                .Cast<Categories>()
                .FirstOrDefault(c => c.CategoryId == category.CategoryId);

            if (itemToUpdate != null)
            {
                int index = _comboBox.Items.IndexOf(itemToUpdate);
                _comboBox.Items[index] = category;
            }
            // refresh listbox
            _comboBox.Refresh();
        }

        /// <summary>
        /// Adds a new category item to the ComboBox.
        /// Checks if the category already exists in the ComboBox before adding.
        /// </summary>
        /// <param name="category">The category to be added.</param>
        public void AddCategoryItem(Categories category)
        {
            if (!_comboBox.Items.Cast<Categories>().Any(c => c.CategoryId == category.CategoryId))
            {
                _comboBox.Items.Add(category);
            }
        }
    }

}
