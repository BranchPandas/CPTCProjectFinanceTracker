using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker;

public class Transactions
{
    [Key]
    public int TransationId { get; set; }
    public DateOnly TransactionDate { get; set; }
    [Required]
    public int AccountId { get; set; }
    [Required]
    public decimal TransactionAmount { get; set; }
    [Required]
    public string? TransactionType { get; set; }
    public string? TransactionDescription { get; set; }
    [Required]
    public int CategoryId { get; set; }
}
