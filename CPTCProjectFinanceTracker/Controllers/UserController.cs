using CPTCProjectFinanceTracker.Database;
using CPTCProjectFinanceTracker.Models;
using CPTCProjectFinanceTracker.Views;
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
        _context = new FinanceTrackingContext();
    }

    /// <summary>
    /// Loads all users from the database and converts them to UserDisplayDTO objects.
    /// Each DTO contains the user's ID and username for display purposes.
    /// </summary>
    public List<UserDisplayDTO> LoadUsers()
    {
        List<UserDisplayDTO> users = _context.Users
            .Select(user => new UserDisplayDTO
            {
                UserId = user.UserID,
                DisplayText = user.UserName
            }).ToList();
        return users;
    }

    /// <summary>
    /// This will be implemented once the Users table is linked to the Accounts table
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    internal object GetUserAccount(int userId)
    {
        throw new NotImplementedException();
    }
    public User? GetUserById(int userId)
    {
        return _context.Users.FirstOrDefault(u => u.UserID == userId);
    }

    public void AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public void UpdateUser(User user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();
    }

}

/// <summary>
/// This is a TEMPORARY class until the Users table is linked to the Accounts table
/// </summary>
public class TempAccount
{
    public int AccountId { get; set; }
    public decimal Balance { get; set; }

    public TempAccount GetUserAccount(int userId)
    {
        // Temporary mock implementation
        return new TempAccount
        {
            AccountId = userId,  // Using userId as AccountId for testing
            Balance = 0
        };
    }
}



