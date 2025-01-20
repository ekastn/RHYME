using System.Collections.Generic;
using RYHME.model;

namespace RYHME.Services
{
    public class ArtistService
    {
        private readonly DatabaseService _databaseService;

        public ArtistService()
        {
            _databaseService = new DatabaseService("Data Source=database.db;Version=3;");
        }

        public IEnumerable<Artist> GetAllArtists()
        {
            string query = "SELECT * FROM Artists";
            return _databaseService.Query<Artist>(query);
        }

        public Artist GetArtistById(int id)
        {
            string query = "SELECT * FROM Artists WHERE Id = @Id";
            return _databaseService.QuerySingle<Artist>(query, new { Id = id });
        }

        public void AddArtist(Artist artist)
        {
            string query = "INSERT INTO Artists (Name, Genre, Contact, ProfilePicture) VALUES (@Name, @Genre, @Contact, @ProfilePicture)";
            _databaseService.ExecuteQuery(query, artist);
        }

        public void UpdateArtist(Artist artist)
        {
            string query = "UPDATE Artists SET Name = @Name, Genre = @Genre, Contact = @Contact, ProfilePicture = @ProfilePicture WHERE Id = @Id";
            _databaseService.ExecuteQuery(query, artist);
        }

        public void DeleteArtist(int id)
        {
            string query = "DELETE FROM Artists WHERE Id = @Id";
            _databaseService.ExecuteQuery(query, new { Id = id });
        }

        public IEnumerable<Artist> SearchArtists(string searchTerm)
        {
            string query = "SELECT * FROM Artists WHERE Name LIKE @SearchTerm OR Genre LIKE @SearchTerm OR Contact LIKE @SearchTerm";
            return _databaseService.Query<Artist>(query, new { SearchTerm = "%" + searchTerm + "%" });
        }
    }
}
