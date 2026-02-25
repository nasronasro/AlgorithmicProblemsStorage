
using AlgorithmicProblemsStorage.Domain.Entities;
using AlgorithmicProblemsStorage.Infrastructure.Data;
using AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories
{
    public class PlatformeRepository : IPlatformeRepository
    {
        private readonly ISqlConnectionFactory _factory;

        public PlatformeRepository(ISqlConnectionFactory factory) => _factory = factory;

        public Dictionary<int, string> GetAllPlatformes()
        {
            Dictionary<int, string> platformeList = new();
            const string query = "select Id, Name from Platform";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);

            con.Open();

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = reader.GetInt32(0);
                string Name = reader.GetString(1);

                platformeList.Add(Id,Name);
            }
            return platformeList;
        }

        public Platforme? GetPlatformeByName(string name)
        {
            const string query = "select Id, Name from Platform where Name = @Name";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", name);

            con.Open();

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null; 

            return new Platforme
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1)
            };
        }
    }
}
