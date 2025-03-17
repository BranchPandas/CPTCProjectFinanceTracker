using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models;

/// <summary>
/// The Reminder class represents a user's reminder in the finance tracker application.
/// </summary>
public class Reminder
{
    /// <summary>
    /// Primary key for the reminders table
    /// </summary>
    [Key]
    public int ReminderId { get; set; }

    /// <summary>
    /// Date of the reminder
    /// </summary>
    public DateTime ReminderDate { get; set; }

    /// <summary>
    /// Description of the reminder
    /// </summary>
    [Required]
    public required string ReminderDescription { get; set; }

    /// <summary>
    /// Get UserId from User table
    /// </summary>
    public virtual required User User { get; set; }

    /// <summary>
    /// Link ReminderId to ReminderTrigger table
    /// </summary>
    public virtual required ICollection<ReminderTrigger> ReminderTriggers { get; set; }
}