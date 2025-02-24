using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models
{
    /// <summary>
    /// The Category class represents a category in the finance tracker application.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// The unique identifier for each Category
        /// </summary>
        [Key]
        public int CategoryId { get; set; }

        /// <summary>
        /// The name of the Category
        /// </summary>
        [Required]
        public required string CategoryName { get; set; }

        /// <summary>
        /// The type of the Category. Either expense or income.
        /// </summary>
        [Required]
        public required string CategoryType { get; set; }

        /// <summary>
        /// Link CateroryId to the Budget table
        /// </summary>
        public required virtual ICollection<Budget> Budgets { get; set; }

        /// <summary>
        /// Link CategoryId to the Transaction table
        /// </summary>
        public required virtual ICollection<Transaction> Transactions { get; set; }
    }
}
