
using System.Data;
using AlgorithmicProblemsStorage.Domain.Entities;
using AlgorithmicProblemsStorage.Infrastructure.Data;
using AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly ISqlConnectionFactory _factory;

        public TagRepository(ISqlConnectionFactory factory) => _factory = factory;
        public int AddTag(Tag tag)
        {
            const string query = @"insert into Tag(Name) values (@Name);
                                    SELECT CAST(SCOPE_IDENTITY() AS int);";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 200).Value = tag.Name;
            con.Open();
            return (int)cmd.ExecuteScalar();
        }

        public int GetTagIdByName(string name)
        {
            const string query = @"select Id from Tag where name = @Name";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 200).Value = name;
            con.Open();
            
            return (int)cmd.ExecuteScalar();
        }

        public List<Tag> ListTags()
        {
            List<Tag> tags = new();
            const string query = "select * from Tag";
            using var con = _factory.Create();
            using var cmd = new SqlCommand(query, con);
            con.Open();
            using var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Tag tag = new Tag
                {
                    Id = dr.GetInt32(0),
                    Name = dr.GetString(1),
                };
                tags.Add(tag);
            }

            return tags;
        }
    }
}
