using CPTCProjectFinanceTracker.Database;
using CPTCProjectFinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCProjectFinanceTracker.Controllers
{
    internal class CategoryController
    {
        /// <summary>
        /// Field to hold the database context
        /// </summary>
        private readonly FinanceTrackingContext _context;

        /// <summary>
        /// Constructor to initialize the database context 
        /// </summary>
        public CategoryController()
        {
            _context = new FinanceTrackingContext();
        }


        // CRUD functionality for Categories
        // The CategoryType is based on which for is open (See TransactionType enum)

        public void Add(Category category) 
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public List<Category> GetAll(TransactionType transactionType)
        {
            return _context.Categories.Where(c => c.CategoryType == transactionType.ToString()).ToList();
        }
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}

