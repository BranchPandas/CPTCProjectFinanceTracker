using CPTCProjectFinanceTracker.Controllers;
using CPTCProjectFinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPTCProjectFinanceTracker.Views;
public partial class ManageUsersForm : Form
{
    private readonly UserController _controller;
    private readonly User _user;
    public ManageUsersForm()
    {
        InitializeComponent();
        _controller = new UserController();
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
        // Create a new user
        User newUser = new User
        {
            UserName = txtbxUserName.Text,
            UserEmail = txtbxUserEmail.Text,
            UserPassword = txtbxUserPassword.Text,
            CreatedAt = DateTime.Now,
            Accounts = new List<Account>(),
            Budgets = new List<Budget>(),
            Reminders = new List<Reminder>()
        };
        // Create default account
        Account defaultAccount = new Account
        {
            AccountName = "Default Account",
            AccountBalance = 0,
            User = newUser,
            Transactions = new List<Transaction>()
        };

        // Add the default account to user's accounts collection
        newUser.Accounts.Add(defaultAccount);
        // Add the user to the database
        _controller.AddUser(newUser);
        Close();
    }


}
