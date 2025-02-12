using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RYHME.Database;
using RYHME.Models;

namespace RYHME.Controllers
{
    public class UserController
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var user = _context.Users.Find(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public User GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User AuthenticateUser(string username, string passwordHash)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == passwordHash);
        }
    }
}
