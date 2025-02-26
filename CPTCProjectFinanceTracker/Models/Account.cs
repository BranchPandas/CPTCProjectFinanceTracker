using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models;

/// <summary>
/// The Account class represents a user's account in the finance tracker application.
/// </summary>
public class Account
{
    /// <summary>
    /// The unique identifier for each Account
    /// </summary>
    [Key]
    public int AccountId { get; set; }

    /// <summary>
    /// The name of the Account
    /// </summary>
    [Required]
    public  required string AccountName { get; set; }

    /// <summary>
    /// The current balance of the Account
    /// </summary>
    [Required]
    public decimal AccountBalance { get; set; }

    /// <summary>
    /// Get UserId from User table
    /// </summary>
    public virtual required User User { get; set; }

    /// <summary>
    /// Link AccountId to Transaction table
    /// </summary>
    public virtual required ICollection<Transaction> Transactions { get; set; }

}

