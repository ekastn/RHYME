using RYHME.Models;

namespace RYHME.Utils
{
    public class SessionManager
    {
        private User _loggedInUser;

        public void SetLoggedInUser(User user)
        {
            _loggedInUser = user;
        }

        public User GetLoggedInUser()
        {
            return _loggedInUser;
        }
    }
}
