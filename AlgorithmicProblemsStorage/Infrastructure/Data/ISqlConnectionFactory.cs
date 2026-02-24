using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace AlgorithmicProblemsStorage.Infrastructure.Data
{
    public interface ISqlConnectionFactory
    {
        SqlConnection Create();
    }
}
