using System.Collections.Generic;
using RYHME.model;
using System.Linq;

namespace RYHME.Services
{
    public class ReleaseService
    {
        private readonly DatabaseService _databaseService;

        public ReleaseService()
        {
            _databaseService = new DatabaseService("Data Source=release_schedule.db;Version=3;");
        }

        public IEnumerable<ReleaseSchedule> GetAllReleases()
        {
            string query = "SELECT * FROM ReleaseSchedules";
            return _databaseService.Query<ReleaseSchedule>(query);
        }

        public void AddRelease(ReleaseSchedule release)
        {
            string query = "INSERT INTO ReleaseSchedules (AlbumId, SongId, ReleaseDate, Status) VALUES (@AlbumId, @SongId, @ReleaseDate, @Status)";
            _databaseService.ExecuteQuery(query, release);
        }

        public void UpdateRelease(ReleaseSchedule release)
        {
            string query = "UPDATE ReleaseSchedules SET AlbumId = @AlbumId, SongId = @SongId, ReleaseDate = @ReleaseDate, Status = @Status WHERE Id = @Id";
            _databaseService.ExecuteQuery(query, release);
        }

        public void DeleteRelease(int releaseId)
        {
            string query = "DELETE FROM ReleaseSchedules WHERE Id = @Id";
            _databaseService.ExecuteQuery(query, new { Id = releaseId });
        }
    }
}
