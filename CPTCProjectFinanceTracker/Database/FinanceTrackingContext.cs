using CPTCProjectFinanceTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Database;

public class FinanceTrackingContext : DbContext
{
    public FinanceTrackingContext()
    {

    }
    /// <summary>
    /// This is how the database is being created and its connection string
    /// </summary>
    /// <param name="options"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Database = The desired name for the database
        // Server = The server we are connecting to. LocalDB is included with Visual Studio
        // Trusted_Connection = True means we are using Windows Authentication
        options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CPTCFinanceTracker;Trusted_Connection=True;");
    }
    /// <summary>
    /// This tells EF Core to track Transactions in the database.
    /// This is the table that will be created in the database.
    /// </summary>
    public DbSet<Transactions> Transactions { get; set; }
}
