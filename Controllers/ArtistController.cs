using System;
using System.Collections.Generic;
using System.Linq;
using RYHME.Database;
using RYHME.Models;
using RYHME.Utils;

namespace RYHME.Controllers
{
    public class ArtistController
    {
        private readonly AppDbContext _context;
        private readonly SessionManager _sessionManager;

        public ArtistController(AppDbContext context, SessionManager sessionManager)
        {
            _context = context;
            _sessionManager = sessionManager;
        }

        public List<Artist> GetAllArtists()
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            return _context.Artists
                .Where(a => a.ManagerId == loggedInUser.Id)
                .ToList();
        }

        public Artist GetArtistById(int id)
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            return _context.Artists
                .FirstOrDefault(a => a.Id == id && a.ManagerId == loggedInUser.Id);
        }

        public void AddArtist(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
        }

        public void UpdateArtist(Artist artist)
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            var existingArtist = _context.Artists
                .FirstOrDefault(a => a.Id == artist.Id && a.ManagerId == loggedInUser.Id);
            if (existingArtist != null)
            {
                existingArtist.Name = artist.Name;
                existingArtist.Genre = artist.Genre;
                existingArtist.Contact = artist.Contact;
                existingArtist.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
            }
        }

        public void DeleteArtist(int id)
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            var artist = _context.Artists
                .FirstOrDefault(a => a.Id == id && a.ManagerId == loggedInUser.Id);
            if (artist != null)
            {
                _context.Artists.Remove(artist);
                _context.SaveChanges();
            }
        }
    }
}
