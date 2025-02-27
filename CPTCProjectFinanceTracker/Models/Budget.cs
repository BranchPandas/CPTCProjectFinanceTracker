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
    /// The Budget class represents a user's budget in the finance tracker application.
    /// </summary>
    public class Budget
    {
        /// <summary>
        /// Primary key for the budgets table
        /// </summary>
        [Key]
        public int BudgetId { get; set; }

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
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Get UserId from User table
        /// </summary>
        public virtual required User User { get; set; }

        /// <summary>
        /// Link CategoryId to Category table
        /// </summary>
        public virtual required Category Category { get; set; }


    }
}
