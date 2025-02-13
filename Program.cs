using RYHME.Controllers;
using RYHME.Database;
using RYHME.view;

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

            AppDbContext dbContext = new AppDbContext();
            ArtistController artistController = new ArtistController(dbContext);
            AlbumController albumController = new AlbumController(dbContext);
            SongController songController = new SongController(dbContext);
            ReleaseController releaseController = new ReleaseController(dbContext);

            Application.Run(new StartUpForm());
            Application.Run(new MainForm(artistController, albumController, songController, releaseController));
        }
    }
}
