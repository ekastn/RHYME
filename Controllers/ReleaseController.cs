using System;
using System.Collections.Generic;
using System.Linq;
using RYHME.Database;
using RYHME.Models;
using RYHME.Utils;

namespace RYHME.Controllers
{
    public class ReleaseController
    {
        private readonly AppDbContext _context;
        private readonly SessionManager _sessionManager;

        public ReleaseController(AppDbContext context, SessionManager sessionManager)
        {
            _context = context;
            _sessionManager = sessionManager;
        }

        public List<Release> GetAllReleases()
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            return _context.Releases
                .Where(r => r.CreatedByUserId == loggedInUser.Id)
                .ToList();
        }

        public Release GetReleaseById(int id)
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            return _context.Releases
                .FirstOrDefault(r => r.Id == id && r.CreatedByUserId == loggedInUser.Id);
        }

        public void AddRelease(Release release)
        {
            _context.Releases.Add(release);
            _context.SaveChanges();
        }

        public void UpdateRelease(Release release)
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            var existingRelease = _context.Releases
                .FirstOrDefault(r => r.Id == release.Id && r.CreatedByUserId == loggedInUser.Id);
            if (existingRelease != null)
            {
                existingRelease.Type = release.Type;
                existingRelease.AlbumId = release.AlbumId;
                existingRelease.SongId = release.SongId;
                existingRelease.Status = release.Status;
                existingRelease.ScheduledDate = release.ScheduledDate;
                existingRelease.ReleaseDate = release.ReleaseDate;
                existingRelease.Notes = release.Notes;
                existingRelease.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
            }
        }

        public void DeleteRelease(int id)
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            var release = _context.Releases
                .FirstOrDefault(r => r.Id == id && r.CreatedByUserId == loggedInUser.Id);
            if (release != null)
            {
                _context.Releases.Remove(release);
                _context.SaveChanges();
            }
        }

        public int GetUpcoamingReleasesCount()
        {
            var loggedInUser = _sessionManager.GetLoggedInUser();
            return _context.Releases
                .Count(r => r.ScheduledDate > DateTime.Now && r.CreatedByUserId == loggedInUser.Id);
        }
    }
}
