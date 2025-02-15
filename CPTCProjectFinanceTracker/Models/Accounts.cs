using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models;

public class Accounts
{
    /// <summary>
    /// The unique identifier for each Account
    /// </summary>
    [Key]
    public int AccountId { get; set; }

    /// <summary>
    /// The unique identifier for each User
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
