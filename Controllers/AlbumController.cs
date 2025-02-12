using System;
using System.Collections.Generic;
using System.Linq;
using RYHME.Database;
using RYHME.Models;

namespace RYHME.Controllers
{
    public class AlbumController
    {
        private readonly AppDbContext _context;

        public AlbumController(AppDbContext context)
        {
            _context = context;
        }

        public List<Album> GetAllAlbums()
        {
            return _context.Albums.ToList();
        }

        public Album GetAlbumById(int id)
        {
            return _context.Albums.Find(id);
        }

        public void AddAlbum(Album album)
        {
            _context.Albums.Add(album);
            _context.SaveChanges();
        }

        public void UpdateAlbum(Album album)
        {
            var existingAlbum = _context.Albums.Find(album.Id);
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
            var album = _context.Albums.Find(id);
            if (album != null)
            {
                _context.Albums.Remove(album);
                _context.SaveChanges();
            }
        }
    }
}
