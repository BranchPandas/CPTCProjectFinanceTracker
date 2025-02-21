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
public partial class UserSelectionForm : Form
{
    private readonly UserController _controller;
    // have to ask Joe about this
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int SelectedUserId { get; private set; }
    public UserSelectionForm()
    {
        InitializeComponent();
        _controller = new UserController();
        DisplayUsers();
    }
    /// <summary>
    /// Gets the list of users from the controller and displays them in the combo box.
    /// </summary>
    public void DisplayUsers()
    {
        try
        {
            // Get the list of users from the controller
            List<UserDisplayDTO> users = _controller.LoadUsers();
            // Display the users in the combo box
            cbxUserSelection.DataSource = users;
            cbxUserSelection.DisplayMember = "DisplayText";
            cbxUserSelection.ValueMember = "UserId";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading users." + ex.Message);
        }
    }
    private void btnEnterApp_Click(object sender, EventArgs e)
    {
        try
        {
            if (cbxUserSelection.SelectedValue == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            // Store the selected user ID
            SelectedUserId = (int)cbxUserSelection.SelectedValue;

            // Open HomeScreen with selected user
            HomeScreen homeScreen = new HomeScreen(SelectedUserId);
            homeScreen.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error selecting user: " + ex.Message);
        }
    }
}
