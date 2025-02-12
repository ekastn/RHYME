using System;
using System.Collections.Generic;
using System.Linq;
using RYHME.Database;
using RYHME.Models;

namespace RYHME.Controllers
{
    public class SongController
    {
        private readonly AppDbContext _context;

        public SongController(AppDbContext context)
        {
            _context = context;
        }

        public List<Song> GetAllSongs()
        {
            return _context.Songs.ToList();
        }

        public Song GetSongById(int id)
        {
            return _context.Songs.FirstOrDefault(s => s.Id == id);
        }

        public void AddSong(Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
        }

        public void UpdateSong(Song song)
        {
            var existingSong = _context.Songs.FirstOrDefault(s => s.Id == song.Id);
            if (existingSong != null)
            {
                existingSong.Title = song.Title;
                existingSong.AlbumId = song.AlbumId;
                existingSong.Duration = song.Duration;
                existingSong.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
            }
        }

        public void DeleteSong(int id)
        {
            var song = _context.Songs.FirstOrDefault(s => s.Id == id);
            if (song != null)
            {
                _context.Songs.Remove(song);
                _context.SaveChanges();
            }
        }
    }
}
