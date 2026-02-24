using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using AlgorithmicProblemsStorage.Domain.Entities;
using AlgorithmicProblemsStorage.Infrastructure.Data;
using AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories
{
    public class AlgorithmRepository : IAlgorithmRepository
    {
        private readonly ISqlConnectionFactory _factory;

        public AlgorithmRepository(ISqlConnectionFactory factory) => _factory = factory;
        public int AddAlgo(Algorithm algo)
        {
            string query = @"insert into Algorithm(Title, PublishedAt, Link, DifficultyId, PlatformId, Code) 
                values (@Title, @PublishedAt, @Link, @DifficultyId, @PlatformId, @Code); 
                SELECT CAST(SCOPE_IDENTITY() AS int);";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 200).Value = algo.Title;
            cmd.Parameters.Add("@PublishedAt", SqlDbType.NVarChar, 50).Value = algo.CreatedAt;
            cmd.Parameters.Add("@Link", SqlDbType.NVarChar, 500).Value = algo.Link;
            cmd.Parameters.Add("@DifficultyId", SqlDbType.Int).Value = algo.DifficultyId;
            cmd.Parameters.Add("@PlatformId", SqlDbType.Int).Value = algo.PlatformId;
            cmd.Parameters.Add("@Code", SqlDbType.NVarChar).Value = algo.Code;

            con.Open();
            return (int) cmd.ExecuteScalar()!;
            
        }

        public void AddTagAlgo(Algorithm algo, Tag tag)
        {
            string query = "insert into AlgorithmTag(AlgorithmId,TagId) values (@algorithmId, @TagId)";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("@algorithmId", SqlDbType.Int).Value = algo.Id;
            cmd.Parameters.Add("@TagId", SqlDbType.Int).Value = tag.Id;

            con.Open();
            cmd.ExecuteNonQuery();
        }

    }
}
