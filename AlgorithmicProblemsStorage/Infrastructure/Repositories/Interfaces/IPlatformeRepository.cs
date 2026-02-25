using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmicProblemsStorage.Domain.Entities;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces
{
    public interface IPlatformeRepository
    {
        Platforme? GetPlatformeByName(string name);
        Dictionary<int,string> GetAllPlatformes();
    }
}
