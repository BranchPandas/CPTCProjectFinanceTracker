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
using CPTCProjectFinanceTracker.Utilities;


namespace CPTCProjectFinanceTracker;

public partial class AddIncomeForm : Form
{
    private readonly TransactionController _controller;
    private readonly HomeScreen _homeScreen;
    public CategoryManager _categoryManager;


    public AddIncomeForm(HomeScreen homeScreen)
    {
        InitializeComponent();
        _controller = new TransactionController();
        _homeScreen = homeScreen;
        _categoryManager = new CategoryManager(cmboBxIncomeCategory);

        // Add the Income Categories to the ComboBox    
        CategoryController categoryController = new();
        List<Categories> categories = categoryController.GetAll(TransactionType.Income);
        foreach (Categories category in categories)
        {
            cmboBxIncomeCategory.Items.Add(category);
        }
    }

    private void btnAddIncomeTransaction_Click(object sender, EventArgs e)
    {
        try
        {
            var transaction = new Transactions
            {
                TransactionId = 0, // TODO: Get transaction ID from database
                AccountId = 1, // TODO: Get account ID from user selection
                CategoryId = ((Categories)cmboBxIncomeCategory.SelectedItem!).CategoryId, // TODO: Get category ID from user selection
                TransactionAmount = decimal.Parse(txtbxIncomeAmount.Text),
                TransactionType = "Income",
                TransactionDescription = txtbxIncomeDescription.Text,
                TransactionDate = DateOnly.FromDateTime(dtpIncomeDate.Value)
            };

            // Let controller handle the transaction
            _controller.SaveTransaction(transaction);
            ClearFields();
            Confirm();
            //_homeScreen.LoadAccountBalance();
            _homeScreen.LoadRecentTransactions();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void ClearFields()
    {
        txtbxIncomeAmount.Clear();
        txtbxIncomeDescription.Clear();
    }

    private void Confirm()
    {
        MessageBox.Show("Income added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnManageCategories_Click(object sender, EventArgs e)
    {
        // Open the ManageCategoriesForm
        Views.FormManageCategories manageCategoriesForm = new Views.FormManageCategories(TransactionType.Income, this);
        manageCategoriesForm.Show();
    }
}