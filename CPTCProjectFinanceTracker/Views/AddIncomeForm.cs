using CPTCProjectFinanceTracker.Models;
using CPTCProjectFinanceTracker.Controllers;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;


namespace CPTCProjectFinanceTracker;

public partial class AddIncomeForm : Form
{
    private readonly TransactionController _controller;

    public AddIncomeForm()
    {
        InitializeComponent();
        _controller = new TransactionController();
    }

    private void btnAddIncomeTransaction_Click(object sender, EventArgs e)
    {
        try
        {
            var transaction = new Transactions
            {
                TransactionId = 0, // TODO: Get transaction ID from database
                AccountId = 1, // TODO: Get account ID from user selection
                CategoryId = 1, // TODO: Get category ID from user selection
                TransactionAmount = decimal.Parse(txtbxIncomeAmount.Text),
                TransactionType = "Income",
                TransactionDescription = txtbxIncomeDescription.Text,
                TransactionDate = DateOnly.FromDateTime(DateTime.Now)
            };

            // Let controller handle the transaction
            _controller.SaveTransaction(transaction);
            ClearFields();
            Confirm();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    } 
    private void ClearFields()
    {
        txtbxIncomeName.Clear();
        txtbxIncomeAmount.Clear();
        txtbxIncomeDescription.Clear();
    }

    private void Confirm()
    {
        MessageBox.Show("Transaction added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}