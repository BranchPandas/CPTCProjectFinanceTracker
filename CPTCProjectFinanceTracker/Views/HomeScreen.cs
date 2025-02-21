using CPTCProjectFinanceTracker.Controllers;
using Microsoft.Identity.Client;

namespace CPTCProjectFinanceTracker;

public partial class HomeScreen : Form
{
    private readonly TransactionController _controller;
    private readonly UserController _userController;
    private readonly int _userId;
    public HomeScreen(int userId)
    {
        InitializeComponent();
        _userController = new UserController();
        _userId = userId;
        _controller = new TransactionController();
        TempLoadAccountBalance();
    }

    // Temporary method for testing user selection
    private void TempLoadAccountBalance()
    {
        try
        {
            // Temporary hardcoded account balance for testing
            int tempAccount = 1; // Assuming account ID 1 exists
            decimal balance = _controller.GetAccountBalance(tempAccount);
            txtCurrentBalance.Text = $"User {_userId} Balance: {balance:C}";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading account balance: " + ex.Message);
        }
    }

    /// <summary>
    /// ORIGINAL METHOD THAT WILL BE IMPLEMENTED ONCE THE USERS TABLE IS LINKED TO THE ACCOUNTS TABLE
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //public void LoadAccountBalance()
    //{
    //    try
    //    {
    //        // Get account ID for current user
    //        var account = _userController.GetUserAccount(_userId);
    //        if (account != null)
    //        {
    //            decimal balance = _controller.GetAccountBalance(account);
    //            txtCurrentBalance.Text = $"{balance:C}";
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show("Error loading account balance: " + ex.Message);
    //    }
    //}
    private void btnAddExpense_Click(object sender, EventArgs e)
    {
        AddExpensesForm addExpensesForm = new AddExpensesForm(this);
        addExpensesForm.Show();
    }

    private void btnAddIncome_Click(object sender, EventArgs e)
    {
        AddIncomeForm addIncomeForm = new AddIncomeForm(this);
        addIncomeForm.Show();
    }
}
