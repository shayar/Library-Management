using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryServices
{
    public class LibraryBranchService : ILibraryBranch
    {
        private readonly LibraryContext _context;

        public LibraryBranchService(LibraryContext context)
        {
            _context = context;
        }

        public void Add(LibraryBranch newBranch)
        {
            _context.Add(newBranch);
            _context.SaveChanges();
        }

        public LibraryBranch Get(int branchId)
        {
            return GetAll()
                .FirstOrDefault(m => m.Id == branchId);
        }

        public IEnumerable<LibraryBranch> GetAll()
        {
            return _context.LibraryBranches
                .Include(m => m.Patrons)
                .Include(m => m.LibraryAssets);
        }

        public IEnumerable<LibraryAsset> GetAssets(int branchId)
        {
            return _context.LibraryBranches
                .Include(m => m.LibraryAssets)
                .FirstOrDefault(m => m.Id == branchId).LibraryAssets;
        }

        public IEnumerable<string> GetBranchHours(int branchId)
        {
            var hours = _context.BranchHours
                .Where(m => m.Branch.Id == branchId);

            return DataHelpers.HumanizeBizHours(hours);
        }

        public IEnumerable<Patron> GetPatrons(int branchId)
        {
            return _context.LibraryBranches
                .Include(m => m.Patrons)
                .FirstOrDefault(m => m.Id == branchId)
                .Patrons;
        }

        public bool IsBranchOpen(int branchId)
        {
            var currentTimeHour = DateTime.Now.Hour;
            var currentDayOfWeek = (int)DateTime.Now.DayOfWeek + 1;
            var hours = _context.BranchHours
                .Where(m => m.Branch.Id == branchId);
            var daysHours = hours
                .FirstOrDefault(m => m.DayOfWeek == currentDayOfWeek);

            return currentTimeHour < daysHours.CloseTime && currentTimeHour > daysHours.OpenTime;
        }
    }
}
