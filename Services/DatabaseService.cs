using System.Data.SQLite;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace RYHME.Services
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(_connectionString);
        }

        public void ExecuteQuery(string query, object parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                connection.Execute(query, parameters);
            }
        }

        public IEnumerable<T> Query<T>(string query, object parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                return connection.Query<T>(query, parameters).ToList();
            }
        }

        public T QuerySingle<T>(string query, object parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                return connection.QuerySingleOrDefault<T>(query, parameters);
            }
        }
    }
}
