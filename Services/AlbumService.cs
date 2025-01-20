using System.Collections.Generic;
using RYHME.model;

namespace RYHME.Services
{
    public class AlbumService
    {
        private readonly DatabaseService _databaseService;

        public AlbumService()
        {
            _databaseService = new DatabaseService("Data Source=database.db;Version=3;");
        }

        public IEnumerable<Album> GetAllAlbums()
        {
            string query = "SELECT * FROM Albums";
            return _databaseService.Query<Album>(query);
        }

        public Album GetAlbumById(int id)
        {
            string query = "SELECT * FROM Albums WHERE Id = @Id";
            return _databaseService.QuerySingle<Album>(query, new { Id = id });
        }

        public void AddAlbum(Album album)
        {
            string query = "INSERT INTO Albums (Title, ArtistId, ReleaseYear, Genre, CoverImage) VALUES (@Title, @ArtistId, @ReleaseYear, @Genre, @CoverImage)";
            _databaseService.ExecuteQuery(query, album);
        }

        public void UpdateAlbum(Album album)
        {
            string query = "UPDATE Albums SET Title = @Title, ArtistId = @ArtistId, ReleaseYear = @ReleaseYear, Genre = @Genre, CoverImage = @CoverImage WHERE Id = @Id";
            _databaseService.ExecuteQuery(query, album);
        }

        public void DeleteAlbum(int id)
        {
            string query = "DELETE FROM Albums WHERE Id = @Id";
            _databaseService.ExecuteQuery(query, new { Id = id });
        }

        public IEnumerable<Album> SearchAlbums(string searchTerm)
        {
            string query = "SELECT * FROM Albums WHERE Title LIKE @SearchTerm OR Genre LIKE @SearchTerm";
            return _databaseService.Query<Album>(query, new { SearchTerm = "%" + searchTerm + "%" });
        }
    }
}
