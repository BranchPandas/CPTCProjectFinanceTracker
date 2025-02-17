using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models
{
    /// <summary>
    /// The Budgets class represents a user's budget in the finance tracker application.
    /// </summary>
    public class Budgets
    {
        /// <summary>
        /// Primary key for the budgets table
        /// </summary>
        [Key]
        public int BudgetId { get; set; }

        /// <summary>
        /// Foreign key to the users table
        /// </summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>
        /// Foreign key to the categories table
        /// </summary>
        [Required]
        public int CategoryId { get; set; }

        /// <summary>
        /// The amount budgeted for the category
        /// </summary>
        [Required]
        public decimal BudgetAmount { get; set; }

        /// <summary>
        /// The start date of the budget
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date of the budget
        /// </summary>
        [Required]
        public DateTime EndDate
        {
            get; set;
        }
    }
}
