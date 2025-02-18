using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPTCProjectFinanceTracker.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.Identity.Client;
using CPTCProjectFinanceTracker.Models;


namespace CPTCProjectFinanceTracker.Controllers.Tests
{
    [TestClass()]
    public class TransactionControllerTests
    {
        public TransactionController tc;

       [TestInitialize]
        public void TestInitialize()
        {
            // Arrange
            tc = new TransactionController();
        }

        [TestMethod()]
        public void SaveTransaction_WithCorrectData_DataIsNowInDB()
        {

            // Arrange
            Transactions transaction = new()
            {
                TransactionAmount = 100.00m,
                TransactionType = "Deposit",
                TransactionDate = DateOnly.FromDateTime(DateTime.Now),
                TransactionDescription = "Test transaction",
                CategoryId = 1, // Assuming 1 is a valid category ID for testing
            };

            // Act
            int tcId = tc.SaveTransaction(transaction);

            // Assert
            // Get Transaction by Id
            Transactions? savedTransaction = tc.GetTransactionById(tcId);
            Assert.IsNotNull(savedTransaction);
        }
    }
}