using CPTCProjectFinanceTracker.Controllers;
using CPTCProjectFinanceTracker.Models;
using Microsoft.Identity.Client;

namespace CPTCProjectFinanceTracker;

public partial class HomeScreen : Form
{
    private readonly TransactionController _controller;
    private readonly UserController _userController;
    private readonly int _userId;
    private Users? _user;

    public HomeScreen(int userId)
    {
        InitializeComponent();
        _userController = new UserController();
        _controller = new TransactionController();
        _userId = userId;
        LoadUserData();
        TempLoadAccountBalance();
    }

    private void LoadUserData()
    {
        try
        {
            _user = _userController.GetUserById(_userId);
            if (_user != null)
            {
                label2.Text = $"{_user.UserName}'s Home Screen";
            }
            else
            {
                label2.Text = "Welcome, User!";
                MessageBox.Show("Could not load user data.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            label2.Text = "Welcome, User!";
            MessageBox.Show($"Error loading user data: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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
