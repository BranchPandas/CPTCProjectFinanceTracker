using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPTCProjectFinanceTracker.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPTCProjectFinanceTracker.Models;

namespace CPTCProjectFinanceTracker.Controllers.Tests
{
    [TestClass()]
    public class TransactionControllerTests
    {
        [TestMethod()]
        public void CreateTransactionObj_WithValidData_Works()
        {

            // Arrange
            Transactions transaction = new Transactions()
            {
                TransactionAmount = 100.00m,
                TransactionType = "Deposit",
                TransactionDate = DateOnly.FromDateTime(DateTime.Now),
                TransactionDescription = "Test transaction",
                CategoryId = 1, // Assuming 1 is a valid category ID for testing  
            };
            

            Assert.IsNotNull(transaction);
        }
    }
}