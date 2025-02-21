using CPTCProjectFinanceTracker.Database;
using CPTCProjectFinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Controllers;

/// <summary>
/// Controller class responsible for managing user-related operations in the finance tracker application.
/// </summary>
public class UserController
{
    /// <summary>
    /// The database context instance used for user data operations.
    /// </summary>
    private readonly FinanceTrackingContext _context;

    /// <summary>
    /// Initializes a new instance of the UserController class.
    /// Creates a new database context and loads initial user data.
    /// </summary>
    public UserController()
    {
        _context = new();
        LoadUsers();
    }

    /// <summary>
    /// Loads all users from the database and converts them to UserDisplayDTO objects.
    /// Each DTO contains the user's ID and username for display purposes.
    /// </summary>
    private void LoadUsers()
    {
        List<UserDisplayDTO> users = _context.Users
            .Select(user => new UserDisplayDTO
            {
                UserId = user.UserID,
                DisplayText = user.UserName
            }).ToList();
    }
}
