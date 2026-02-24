using System.Configuration;
using Microsoft.Data.SqlClient;

namespace AlgorithmicProblemsStorage.Infrastructure.Data
{
    public sealed class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly string _connStr;

        public SqlConnectionFactory()
        {
            _connStr = ConfigurationManager
                .ConnectionStrings["MyDbConnection"]
                .ConnectionString;
        }

        public SqlConnection Create() => new SqlConnection(_connStr);
    }
}
