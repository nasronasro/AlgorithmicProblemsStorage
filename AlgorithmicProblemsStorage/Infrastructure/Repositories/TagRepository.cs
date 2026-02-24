using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using AlgorithmicProblemsStorage.Domain.Entities;
using AlgorithmicProblemsStorage.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using static ScintillaNET.Style;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly ISqlConnectionFactory _factory;

        public TagRepository(ISqlConnectionFactory factory) => _factory = factory;
        public void AddTag(Tag tag)
        {
            const string query = "insert into Tag(Name) value (@name);";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", tag.Name);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
