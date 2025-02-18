using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models
{
    /// <summary>
    /// The Reminders class represents a user's reminder in the finance tracker application.
    /// </summary>
    public class Reminders
    {
        /// <summary>
        /// Primary key for the reminders table
        /// </summary>
        [Key]
        public int ReminderId { get; set; }

        /// <summary>
        /// Foreign key to the users table
        /// </summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>
        /// Date of the reminder
        /// </summary>
        public DateTime ReminderDate { get; set; }

        /// <summary>
        /// Description of the reminder
        /// </summary>
        public string ReminderDescription { get; set; }

    }
}
