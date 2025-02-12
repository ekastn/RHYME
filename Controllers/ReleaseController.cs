using System;
using System.Collections.Generic;
using System.Linq;
using RYHME.Database;
using RYHME.Models;

namespace RYHME.Controllers
{
    public class ReleaseController
    {
        private readonly AppDbContext _context;

        public ReleaseController(AppDbContext context)
        {
            _context = context;
        }

        public List<Release> GetAllReleases()
        {
            return _context.Releases.ToList();
        }

        public Release GetReleaseById(int id)
        {
            return _context.Releases.FirstOrDefault(r => r.Id == id);
        }

        public void AddRelease(Release release)
        {
            _context.Releases.Add(release);
            _context.SaveChanges();
        }

        public void UpdateRelease(Release release)
        {
            _context.Releases.Update(release);
            _context.SaveChanges();
        }

        public void DeleteRelease(int id)
        {
            var release = _context.Releases.FirstOrDefault(r => r.Id == id);
            if (release != null)
            {
                _context.Releases.Remove(release);
                _context.SaveChanges();
            }
        }
    }
}
