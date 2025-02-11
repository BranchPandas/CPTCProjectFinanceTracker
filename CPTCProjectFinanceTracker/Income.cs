using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker;

public class Income
{
    [Key]
    public int IncomeId { get; set; }
    public int CategoryId { get; set; }
    [Required]
    public decimal IncomeAmount { get; set; }
    public DateTime IncomeDate { get; set; }
    [Required]
    public int UserId { get; set; }
    public string? IncomeDescription { get; set; }
}
