using CPTCProjectFinanceTracker.Database;
using CPTCProjectFinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CPTCProjectFinanceTracker.Controllers;

public class TransactionController
{
    /// <summary>
    /// Field to hold the database context
    /// </summary>
    private readonly FinanceTrackingContext _context;

    /// <summary>
    /// Constructor to initialize the database context 
    /// </summary>
    public TransactionController()
    {
        _context = new FinanceTrackingContext();
    }

    /// <summary>
    /// Method that takes in a transaction object as a parameter
    /// and saves it to the database
    /// </summary>
    /// <param name="transaction"></param>
    public void SaveTransaction(Models.Transaction transaction)
    {
        _context.Transactions.Add(transaction);
        _context.SaveChanges();
    }

    public decimal GetAccountBalance(int tempAccount)
    {
        var incomes = _context.Transactions
            .Where(t => t.AccountId == tempAccount && t.TransactionType == "Income")
            .Sum(t => t.TransactionAmount);

        var expenses = _context.Transactions
            .Where(t => t.AccountId == tempAccount && t.TransactionType == "Expense")
            .Sum(t => t.TransactionAmount);

        return incomes - expenses;
    }

    /// <summary>
    /// Gets a list of recent transactions ordered by date
    /// </summary>
    /// <param name="accountId">The account ID to get transactions for</param>
    /// <param name="count">Number of recent transactions to retrieve</param>
    /// <returns>List of recent transactions</returns>
    public List<Models.Transaction> GetRecentTransactions(int accountId, int count = 10)
    {
        return _context.Transactions
            .Where(t => t.AccountId == accountId)
            .OrderByDescending(t => t.TransactionDate)
            .Take(count)
            .ToList();
    }
}