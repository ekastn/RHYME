using System;
using System.Collections.Generic;
using System.Linq;
using RYHME.Database;
using RYHME.Models;
using RYHME.Utils;

namespace RYHME.Controllers
{
    public class AlbumController
    {
        private readonly AppDbContext _context;
        private readonly SessionManager _sessionManager;

        public AlbumController(AppDbContext context, SessionManager sessionManager)
        {
            _context = context;
            _sessionManager = sessionManager;
        }

        public List<Album> GetAllAlbums()
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            return _context.Albums
                .Where(a => a.Artist.ManagerId == loggedInUser.Id)
                .ToList();
        }

        public Album GetAlbumById(int id)
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            return _context.Albums
                .FirstOrDefault(a => a.Id == id && a.Artist.ManagerId == loggedInUser.Id);
        }

        public void AddAlbum(Album album)
        {
            _context.Albums.Add(album);
            _context.SaveChanges();
        }

        public void UpdateAlbum(Album album)
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            var existingAlbum = _context.Albums
                .FirstOrDefault(a => a.Id == album.Id && a.Artist.ManagerId == loggedInUser.Id);
            if (existingAlbum != null)
            {
                existingAlbum.Title = album.Title;
                existingAlbum.ArtistId = album.ArtistId;
                existingAlbum.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
            }
        }

        public void DeleteAlbum(int id)
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            var album = _context.Albums
                .FirstOrDefault(a => a.Id == id && a.Artist.ManagerId == loggedInUser.Id);
            if (album != null)
            {
                _context.Albums.Remove(album);
                _context.SaveChanges();
            }
        }
    }
}
