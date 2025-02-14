using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models;

public class Transactions
{
    /// <summary>
    /// Unique identifier for each transaction
    /// </summary>
    [Key]
    public int TransactionId { get; set; }
    /// <summary>
    /// The date of the transaction was created
    /// </summary>
    public DateOnly TransactionDate { get; set; }
    /// <summary>
    /// The account that the transaction is associated with
    /// </summary>
    [Required]
    public int AccountId { get; set; }
    /// <summary>
    /// The amount of the transaction
    /// </summary>
    [Required]
    public decimal TransactionAmount { get; set; }
    /// <summary>
    /// The type of the transaction (Income or Expense)
    /// </summary>
    [Required]
    public string? TransactionType { get; set; }
    /// <summary>
    /// A short description of the transaction (optional)
    /// </summary>
    public string? TransactionDescription { get; set; }
    /// <summary>
    /// The category of the transaction
    /// </summary>
    [Required]
    public int CategoryId { get; set; }

}
