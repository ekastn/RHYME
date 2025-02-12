using System;
using System.Collections.Generic;
using System.Linq;
using RYHME.Database;
using RYHME.Models;

namespace RYHME.Controllers
{
    public class ArtistController
    {
        private readonly AppDbContext _context;

        public ArtistController(AppDbContext context)
        {
            _context = context;
        }

        public List<Artist> GetAllArtists()
        {
            return _context.Artists.ToList();
        }

        public Artist GetArtistById(int id)
        {
            return _context.Artists.Find(id);
        }

        public void AddArtist(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
        }

        public void UpdateArtist(Artist artist)
        {
            var existingArtist = _context.Artists.Find(artist.Id);
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
            var artist = _context.Artists.Find(id);
            if (artist != null)
            {
                _context.Artists.Remove(artist);
                _context.SaveChanges();
            }
        }
    }
}
