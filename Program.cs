using RYHME.Controllers;
using RYHME.Database;
using RYHME.view;
using RYHME.Utils;

namespace RYHME
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            SessionManager sessionManager = new SessionManager();
            AppDbContext dbContext = new AppDbContext(sessionManager);
            ArtistController artistController = new ArtistController(dbContext, sessionManager);
            AlbumController albumController = new AlbumController(dbContext, sessionManager);
            SongController songController = new SongController(dbContext, sessionManager);
            ReleaseController releaseController = new ReleaseController(dbContext, sessionManager);
            UserController userController = new UserController(dbContext);

            Application.Run(new StartUpForm());
            Application.Run(new LoginForm(userController, sessionManager));
            Application.Run(new MainForm(artistController, albumController, songController, releaseController, userController, sessionManager));
        }
    }
}
