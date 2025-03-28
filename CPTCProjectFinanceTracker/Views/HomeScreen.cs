using CPTCProjectFinanceTracker.Controllers;
using CPTCProjectFinanceTracker.Models;
using CPTCProjectFinanceTracker.Utilities;
using CPTCProjectFinanceTracker.Views.Graphs;
using Microsoft.Identity.Client;

namespace CPTCProjectFinanceTracker;

public partial class HomeScreen : Form
{
    private readonly TransactionController _transactionController;
    private readonly UserController _userController;
    private readonly CategoryController _categoryController;

    // Add this to the InitializeComponent method after the grpBxTransactions initialization:

    private readonly int _userId;
    private User? _user;
    private DataGridView dgvRecentTransactions;

    public HomeScreen(int userId)
    {
        InitializeComponent();
        _userController = new UserController();
        _transactionController = new TransactionController();
        _categoryController = new CategoryController();
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
            decimal balance = _transactionController.GetAccountBalance(tempAccount);
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
        //addExpensesForm.Show();
        addExpensesForm.ShowDialog();
    }

    private void btnAddIncome_Click(object sender, EventArgs e)
    {
        AddIncomeForm addIncomeForm = new AddIncomeForm(this);
        //addIncomeForm.Show();
        addIncomeForm.ShowDialog();
    }
    public void LoadRecentTransactions()
    {
        try
        {
            // Temporary using account ID 1 - you should replace this with the actual account ID
            int tempAccount = 1;
            var transactions = _transactionController.GetRecentTransactions(tempAccount);
            var categories = _categoryController.GetAll();



            // This is an example of an "Outer Join" b/c DefaultIfEmpty + "N/a" fallback value
            // To Execute this LINQ query, you run sourceData.ToList();
            var sourceData = CategoryManager.MapCategoryToTransaction(transactions, categories);


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
            dgvRecentTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Category",
                DataPropertyName = "CategoryName",
                HeaderText = "Category",
            });


            dgvRecentTransactions.DataSource = sourceData.ToList();
            dgvRecentTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading transactions: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void toolStripMenuItem_graph1_Click(object sender, EventArgs e)
    {
        Graph1Form graph1Form = new Graph1Form();
        graph1Form.Show();
    }

    private void ToolStripMenuItem_Graph2_Click(object sender, EventArgs e)
    {
        Graph2Form graph2Form = new Graph2Form();
        graph2Form.Show();
    }
}
