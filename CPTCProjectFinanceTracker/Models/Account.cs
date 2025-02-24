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
    /// The foreign key for the User class
    /// </summary>
    [Required]
    public int UserId { get; set; }

    /// <summary>
    /// The name of the Account
    /// </summary>
    [Required]
    public string AccountName { get; set; }

    /// <summary>
    /// The current balance of the Account
    /// </summary>
    [Required]
    public decimal AccountBalance { get; set; }

}