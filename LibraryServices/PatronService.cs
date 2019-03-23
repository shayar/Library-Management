using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class PatronService : IPatron
    {
        private readonly LibraryContext _context;

        public PatronService(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Patron newPatron)
        {
            _context.Add(newPatron);
            _context.SaveChanges();
        }

        public Patron Get(int id)
        {
            return 
                GetAll()
                .FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Patron> GetAll()
        {
            return _context.Patrons
                .Include(m => m.LibraryCard)
                .Include(m => m.HomeLibraryBranch);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return _context.CheckoutHistories
                .Include(m => m.LibraryCard)
                .Include(m => m.LibraryAsset)
                .Where(m => m.Id == cardId)
                .OrderByDescending(m => m.CheckedOut);
        }

        public IEnumerable<Checkouts> GetCheckouts(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return _context.Checkouts
                .Include(m => m.LibraryCard)
                .Include(m => m.LibraryAsset)
                .Where(m => m.Id == cardId);
        }

        public IEnumerable<Holds> GetHolds(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return _context.Holds
                .Include(m => m.LibraryCard)
                .Include(m => m.LibraryAsset)
                .Where(m => m.LibraryCard.Id == cardId)
                .OrderByDescending(m => m.HoldPlaced);
        }
    }
}
