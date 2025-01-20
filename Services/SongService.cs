using System.Collections.Generic;
using System.Linq;
using RYHME.model;

namespace RYHME.Services
{
    public class SongService
    {
        private readonly DatabaseService _databaseService;

        public SongService()
        {
            _databaseService = new DatabaseService("Data Source=ryhme.db;Version=3;");
        }

        public IEnumerable<Song> GetAllSongs()
        {
            var query = "SELECT * FROM Songs";
            return _databaseService.Query<Song>(query);
        }

        public Song GetSongById(int id)
        {
            var query = "SELECT * FROM Songs WHERE Id = @Id";
            return _databaseService.QuerySingle<Song>(query, new { Id = id });
        }

        public void AddSong(Song song)
        {
            var query = "INSERT INTO Songs (Title, AlbumId, Duration, Lyrics) VALUES (@Title, @AlbumId, @Duration, @Lyrics)";
            _databaseService.ExecuteQuery(query, song);
        }

        public void UpdateSong(Song song)
        {
            var query = "UPDATE Songs SET Title = @Title, AlbumId = @AlbumId, Duration = @Duration, Lyrics = @Lyrics WHERE Id = @Id";
            _databaseService.ExecuteQuery(query, song);
        }

        public void DeleteSong(int id)
        {
            var query = "DELETE FROM Songs WHERE Id = @Id";
            _databaseService.ExecuteQuery(query, new { Id = id });
        }

        public IEnumerable<Song> SearchSongs(string searchTerm)
        {
            var query = "SELECT * FROM Songs WHERE Title LIKE @SearchTerm";
            return _databaseService.Query<Song>(query, new { SearchTerm = "%" + searchTerm + "%" });
        }
    }
}
