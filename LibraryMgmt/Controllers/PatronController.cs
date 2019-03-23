using LibraryData;
using LibraryData.Models;
using LibraryMgmt.Models.Patron;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LibraryMgmt.Controllers
{
    public class PatronController : Controller
    {
        private readonly IPatron _patron;

        public PatronController(IPatron patron)
        {
            _patron = patron;
        }

        public IActionResult Index()
        {
            var allPatrons = _patron.GetAll();

            var patronModels = allPatrons
                .Select(m => new PatronDetailModel
                {
                    Id = m.Id,
                    FirstName = m.FirstName,
                    LastName = m.LastName ,
                    LibraryCardId = m.LibraryCard.Id,
                    OverdueFees = m.LibraryCard.Fees,
                    HomeLibraryBranch = m.HomeLibraryBranch.Name
                }).ToList();

            var model = new PatronIndexModel()
            {
                Patrons = patronModels
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var patron = _patron.Get(id);

            var model = new PatronDetailModel
            {
                Id = patron.Id,
                LastName = patron.LastName,
                FirstName = patron.FirstName ,
                Address = patron.Address ,
                HomeLibraryBranch = patron.HomeLibraryBranch?.Name ,
                MemberSince = patron.LibraryCard.Created,
                OverdueFees = patron.LibraryCard.Fees,
                LibraryCardId = patron.LibraryCard.Id,
                Telephone = string.IsNullOrEmpty(patron.TelephoneNumber) ? "No Telephone Number Provided" : patron.TelephoneNumber,
                AssetsCheckedOut = _patron.GetCheckouts(id).ToList() ?? new List<Checkouts>() ,
                CheckoutHistory = _patron.GetCheckoutHistory(id),
                Holds = _patron.GetHolds(id)
            };

            return View(model);
        }

    }
}