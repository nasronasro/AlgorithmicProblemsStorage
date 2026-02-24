
using AlgorithmicProblemsStorage.Domain.Entities;
using AlgorithmicProblemsStorage.Infrastructure.Data;
using AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using static ScintillaNET.Style;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories
{
    public class PlatformeRepository : IPlatformeRepository
    {
        private readonly ISqlConnectionFactory _factory;

        public PlatformeRepository(ISqlConnectionFactory factory) => _factory = factory;
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
