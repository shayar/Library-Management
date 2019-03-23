using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryServices
{
    public class LibraryAssetService : ILibraryAsset
    {
        private readonly LibraryContext _context;

        public LibraryAssetService(LibraryContext context)
        {
            _context = context;
        }

        public void Add(LibraryAsset newAsset)
        {
            _context.Add(newAsset);
            _context.SaveChanges();
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets
                .Include(m => m.Status)
                .Include(m => m.Location);
        }

        public LibraryAsset GetById(int id)
        {
            return
                GetAll()
                .FirstOrDefault(m => m.Id == id);
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            return GetById(id).Location;
            //return _context.LibraryAssets.FirstOrDefault(m => m.Id == id).Location;
        }

        public string GetDeweyIndex(int id)
        {
            if(_context.Books.Any(m => m.Id == id))
            {
                return _context.Books
                    .FirstOrDefault(m => m.Id == id).DeweyIndex;
            }
            else return "";
        }

        public string GetIsbn(int id)
        {
            if (_context.Books.Any(m => m.Id == id))
            {
                return _context.Books
                    .FirstOrDefault(m => m.Id == id).ISBN;
            }
            else return "";
        }

        public string GetTitle(int id)
        {
                return _context.Books
                    .FirstOrDefault(m => m.Id == id).Title;
        }

        public string GetType(int id)
        {
            var book = _context.LibraryAssets.OfType<Book>()
                .Where(m => m.Id == id);

            return book.Any() ? "Book" : "Video";
        }
        public string GetAuthorOrDirector(int id)
        {
            var isBook = _context.LibraryAssets.OfType<Book>()
                .Where(m => m.Id == id).Any();

            var isVideo = _context.LibraryAssets.OfType<Video>()
                .Where(m => m.Id == id).Any();

            return isBook ?
                _context.Books.FirstOrDefault(m => m.Id == id).Author :
                _context.Videos.FirstOrDefault(m => m.Id == id).Director
                ?? "Unknown";
        }
    }
}
