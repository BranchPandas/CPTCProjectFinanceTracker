using CPTCProjectFinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Utilities
{

    /// <summary>
    /// This Utility Class offers the Income/Expense Forms common methods 
    /// for managing categories in the ComboBox.
    /// This ComboBox is used to select the category of the transaction. 
    /// but also can be updated at run time when the user adds, updates or deletes a category.
    /// </summary>
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
        public void RemoveCategoryItem(Category category)
        {
            // Find the category by its ID
            Category? itemToRemove = _comboBox.Items
                .Cast<Category>()
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
        public void UpdateCategoryItem(Category category)
        {
            // Get Category from the list
            Category? itemToUpdate = _comboBox.Items
                .Cast<Category>()
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
        public void AddCategoryItem(Category category)
        {
            if (!_comboBox.Items.Cast<Category>().Any(c => c.CategoryId == category.CategoryId))
            {
                _comboBox.Items.Add(category);
            }
        }


        public static List<MapCategoryToTransaction_ViewModel> MapCategoryToTransaction(List<Transaction> transactions, List<Category> categories)
        {
            var sourceData = from transaction in transactions
                             join category in categories
                             on transaction.CategoryId equals category.CategoryId
                             into transactionCategories
                             from category in transactionCategories.DefaultIfEmpty()
                             select new MapCategoryToTransaction_ViewModel
                             {
                                 TransactionDate = transaction.TransactionDate,
                                 TransactionType = transaction.TransactionType,
                                 TransactionDescription = transaction.TransactionDescription,
                                 TransactionAmount = transaction.TransactionAmount,
                                 CategoryName = category?.CategoryName ?? "N/a"
                             };

            return sourceData.ToList();
        }

        public class MapCategoryToTransaction_ViewModel() { 
            
            public DateOnly TransactionDate { get; set; }
            public string TransactionType { get; set; }
            public string TransactionDescription { get; set; }
            public decimal TransactionAmount { get; set; }
            public string CategoryName { get; set; }

            public override string ToString()
            {
                return $"{TransactionDate.ToString("yyyy-MM-dd")} - {TransactionType}: {TransactionDescription} - {TransactionAmount:C} (Category: {CategoryName})";
            }

        }


    }




}
