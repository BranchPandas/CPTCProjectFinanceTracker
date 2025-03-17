using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models
{
    /// <summary>
    /// The ReminderTrigger class represents a trigger for a reminder in the finance tracker application.
    /// </summary>
    public class ReminderTrigger
    {
        /// <summary>
        /// The unique identifier for each ReminderTrigger
        /// </summary>
        [Key]
        public int ReminderTriggerId { get; set; }

        /// <summary>
        /// The type of the ReminderTrigger
        /// </summary>
        [Required]
        public required string Type { get; set; }

        /// <summary>
        /// Get ReminderId from Reminder table
        /// </summary>
        public virtual required Reminder Reminder { get; set; }
    }
}