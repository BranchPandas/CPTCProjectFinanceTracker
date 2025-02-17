using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models
{
    /// <summary>
    /// The Categories class represents a category in the finance tracker application.
    /// </summary>
    public class Categories
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
        public string CategoryName { get; set; }

        /// <summary>
        /// The type of the Category. Either expense or income.
        /// </summary>
        [Required]
        public string CategoryType { get; set; }
    }
}
