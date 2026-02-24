using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmicProblemsStorage.Domain.Entities;
using AlgorithmicProblemsStorage.Infrastructure.Data;
using AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories
{
    public class DifficultyRepository : IDifficultyRepository
    {
        private readonly ISqlConnectionFactory _factory;

        public DifficultyRepository(ISqlConnectionFactory factory) => _factory = factory;
        public Difficulty? GetDifficultyByName(string name)
        {
            const string query = "select Id, Name from Difficulty where Name = @Name";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", name);

            con.Open();

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new Difficulty
            {
                Id = (int) reader.GetByte(0),
                Name = reader.GetString(1)
            };
        }
    }
}
