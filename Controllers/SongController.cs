using System;
using System.Collections.Generic;
using System.Linq;
using RYHME.Database;
using RYHME.Models;
using RYHME.Utils;

namespace RYHME.Controllers
{
    public class SongController
    {
        private readonly AppDbContext _context;
        private readonly SessionManager _sessionManager;

        public SongController(AppDbContext context, SessionManager sessionManager)
        {
            _context = context;
            _sessionManager = sessionManager;
        }

        public List<Song> GetAllSongs()
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            return _context.Songs
                .Where(s => s.Album.Artist.ManagerId == loggedInUser.Id)
                .ToList();
        }

        public Song GetSongById(int id)
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            return _context.Songs
                .FirstOrDefault(s => s.Id == id && s.Album.Artist.ManagerId == loggedInUser.Id);
        }

        public void AddSong(Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
        }

        public void UpdateSong(Song song)
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            var existingSong = _context.Songs
                .FirstOrDefault(s => s.Id == song.Id && s.Album.Artist.ManagerId == loggedInUser.Id);
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
            var loggedInUser = _sessionManager.GetLoggedInUser();
            var song = _context.Songs
                .FirstOrDefault(s => s.Id == id && s.Album.Artist.ManagerId == loggedInUser.Id);
            if (song != null)
            {
                _context.Songs.Remove(song);
                _context.SaveChanges();
            }
        }
    }
}
