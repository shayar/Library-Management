using LibraryData;
using LibraryMgmt.Models.Branch;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LibraryMgmt.Controllers
{
    public class BranchController : Controller
    {
        private readonly ILibraryBranch _branch;

        public BranchController(ILibraryBranch branch)
        {
            _branch = branch;
        }

        public IActionResult Index()
        {
            var branches = _branch.GetAll()
                .Select(m => new BranchDetailModel {
                    Id = m.Id,
                    Name = m.Name,
                    IsOpen = _branch.IsBranchOpen(m.Id),
                    NumberOfAssets = _branch.GetAssets(m.Id).Count(),
                    NumberOfPatrons = _branch.GetPatrons(m.Id).Count(),

                });
            var model = new BranchIndexModel()
            {
                Branches = branches
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var branch = _branch.Get(id);
            var model = new BranchDetailModel
            {

                Id =branch.Id,
                Name = branch.Name,
                Description = branch.Description,
                Address = branch.Address,
                Telephone = branch.Telephone,
                OpenDate = branch.OpenDate.ToString("yyyy-MM-dd"),
                NumberOfPatrons = _branch.GetPatrons(id).Count(),
                NumberOfAssets = _branch.GetAssets(id).Count(),
                TotalAssetValue = _branch.GetAssets(id).Sum(m => m.Cost),
                ImageUrl = branch.ImageUrl,
                HoursOpen = _branch.GetBranchHours(id)
            };

            return View(model);
        }
    }
}