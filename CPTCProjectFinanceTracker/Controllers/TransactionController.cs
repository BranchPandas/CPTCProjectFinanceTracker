﻿using CPTCProjectFinanceTracker.Database;
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
    public void SaveTransaction(Transactions transaction)
    {
        _context.Transactions.Add(transaction);
        _context.SaveChanges();
    }

    public decimal GetAccountBalance(int accountId)
    {
        var incomes = _context.Transactions
            .Where(t => t.AccountId == accountId && t.TransactionType == "Income")
            .Sum(t => t.TransactionAmount);

        var expenses = _context.Transactions
            .Where(t => t.AccountId == accountId && t.TransactionType == "Expense")
            .Sum(t => t.TransactionAmount);

        return incomes - expenses;
    }

}