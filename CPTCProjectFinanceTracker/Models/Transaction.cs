﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models;

/// <summary>
/// The Transaction class represents a transaction in the finance tracker application.
/// </summary>
public class Transaction
{
    /// <summary>
    /// The unique identifier for each Transaction
    /// </summary>
    [Key]
    public int TransactionId { get; set; }

    /// <summary>
    /// The date of the Transaction
    /// </summary>
    [Required]
    public DateOnly TransactionDate { get; set; }

    /// <summary>
    /// The amount of the Transaction
    /// </summary>
    [Required]
    public decimal TransactionAmount { get; set; }

    /// <summary>
    /// The type of the Transaction
    /// </summary>
    [Required]
    public string? TransactionType { get; set; }

    /// <summary>
    /// The description of the Transaction
    /// </summary>
    [Required]
    public string? TransactionDescription { get; set; }

    /// <summary>
    /// Get AccountId from Account table
    /// </summary>
    public virtual required Account Account { get; set; }

    /// <summary>
    /// Get CategoryId from Category table
    /// </summary>
    public virtual required Category Category { get; set; }

    public int AccountId { get; set; }
    public int CategoryId { get; set; }

    // Other properties and methods

}

// This Enum helps to prevent misspellings of strings
public enum TransactionType
{
    Expense,
    Income
}
