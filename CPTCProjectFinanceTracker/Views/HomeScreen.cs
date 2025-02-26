using CPTCProjectFinanceTracker.Controllers;
using CPTCProjectFinanceTracker.Models;
using Microsoft.Identity.Client;

namespace CPTCProjectFinanceTracker;

public partial class HomeScreen : Form
{
    private readonly TransactionController _controller;
    private readonly UserController _userController;

    // Add this to the InitializeComponent method after the grpBxTransactions initialization:

    private readonly int _userId;
    private Users? _user;
    private DataGridView dgvRecentTransactions;

    public HomeScreen(int userId)
    {
        InitializeComponent();
        _userController = new UserController();
        _controller = new TransactionController();
        _userId = userId;
        LoadUserData();
        TempLoadAccountBalance();
        LoadRecentTransactions();
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
    public void LoadRecentTransactions()
    {
        try
        {
            // Temporary using account ID 1 - you should replace this with the actual account ID
            int tempAccount = 1;
            var transactions = _controller.GetRecentTransactions(tempAccount);

            dgvRecentTransactions.AutoGenerateColumns = false;
            dgvRecentTransactions.Columns.Clear();

            // Add columns
            dgvRecentTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Date",
                DataPropertyName = "TransactionDate",
                HeaderText = "Date"
            });
            dgvRecentTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                DataPropertyName = "TransactionDescription",
                HeaderText = "Description"
            });
            dgvRecentTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Type",
                DataPropertyName = "TransactionType",
                HeaderText = "Type"
            });
            dgvRecentTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Amount",
                DataPropertyName = "TransactionAmount",
                HeaderText = "Amount",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C" }
            });

            dgvRecentTransactions.DataSource = transactions;
            dgvRecentTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading transactions: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
