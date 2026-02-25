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

        public Dictionary<int, String> GetAllDifficulties()
        {
            Dictionary<int,String> difficultyList = new();
            const string query = "select Id, Name from Difficulty";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);

            con.Open();
            using var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var diff =  new Difficulty
                {
                    Id = (int)dr.GetByte(0),
                    Name = dr.GetString(1)
                };
                difficultyList.Add(diff.Id, diff.Name);
            }
            return difficultyList;
        }

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
