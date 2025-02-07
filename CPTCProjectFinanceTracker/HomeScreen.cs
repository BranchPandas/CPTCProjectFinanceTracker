namespace CPTCProjectFinanceTracker
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddExpensesForm addExpensesForm = new AddExpensesForm();
            addExpensesForm.Show();
        }
    }
}
