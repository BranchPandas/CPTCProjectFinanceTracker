﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Models;

/// <summary>
/// The Users class represents a user in the finance tracker application.
/// </summary>
public class Users
{
    /// <summary>
    /// The unique identifier for each User
    /// </summary>
    [Key]
    public int UserID { get; set; }

    /// <summary>
    /// The user's Full name
    /// </summary>
    [Required]
    public string UserName { get; set; }

    /// <summary>
    /// The user's email address
    /// </summary>
    [Required]
    public string UserEmail { get; set; }

    /// <summary>
    /// The user's password
    /// </summary>
    [Required]
    public string UserPassword { get; set; }

    /// <summary>
    /// The time stamp when the user was created
    /// </summary>
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}