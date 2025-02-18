using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models
{
    /// <summary>
    /// The ReminderTriggers class represents a trigger for a reminder in the finance tracker application.
    /// </summary>
    public class ReminderTriggers
    {
        /// <summary>
        /// The unique identifier for each ReminderTriggers
        /// </summary>
        public int ReminderTriggerId { get; set; }

        /// <summary>
        /// The type of the ReminderTriggers
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The foreign key for the Reminders class
        /// </summary>
        public int ReminderId { get; set; }

    }
}
