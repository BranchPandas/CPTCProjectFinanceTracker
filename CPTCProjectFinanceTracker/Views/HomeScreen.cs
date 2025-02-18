using CPTCProjectFinanceTracker.Controllers;

namespace CPTCProjectFinanceTracker;

public partial class HomeScreen : Form
{
    private readonly TransactionController _controller;
    public HomeScreen()
    {
        InitializeComponent();
        _controller = new TransactionController();
        LoadAccountBalance();
    }

    public void LoadAccountBalance()
    {
        try
        {
            // Need to create a method to get the current user's account ID
            int accountId = 1; // Placeholder for actual account ID
            decimal balance = _controller.GetAccountBalance(accountId);
            txtCurrentBalance.Text = $"{balance:C}";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading account balance." + ex.Message);
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
