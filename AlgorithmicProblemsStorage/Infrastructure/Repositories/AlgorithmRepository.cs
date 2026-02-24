using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using AlgorithmicProblemsStorage.Domain.Entities;
using AlgorithmicProblemsStorage.Infrastructure.Data;
using Microsoft.Data.SqlClient;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories
{
    public class AlgorithmRepository : IAlgorithmRepository
    {
        private readonly ISqlConnectionFactory _factory;

        public AlgorithmRepository(ISqlConnectionFactory factory) => _factory = factory;
        public void AddAlgo(Algorithm algo)
        {
            string query = "insert into Algorithm(Title, PublishedAt, Link, DifficultyId, PlatformId, code) " +
                "value (@title, @publishedAt, @link, @DifficultyId, @platformId, @code); ";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@title", algo.Title);
            cmd.Parameters.AddWithValue("@publishedAt", algo.CreatedAt);
            cmd.Parameters.AddWithValue("@link", algo.Link);
            cmd.Parameters.AddWithValue("@DifficultyId", algo.DifficultyId);
            cmd.Parameters.AddWithValue("@platformId", algo.PlatformId);
            cmd.Parameters.AddWithValue("@code", algo.Code);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AddTagAlgo(Algorithm algo, Tag tag)
        {
            string query = "insert into AlgorithmTag(AlgorithmId,TagId) value(@algorithmId, @TagId)";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@algorithmId", algo.Id);
            cmd.Parameters.AddWithValue("@TagId", tag.Id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
