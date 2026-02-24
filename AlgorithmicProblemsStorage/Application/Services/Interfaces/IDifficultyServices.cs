using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmicProblemsStorage.Domain.Entities;

namespace AlgorithmicProblemsStorage.Application.Services.Interfaces
{
    public interface IDifficultyServices
    {
        Difficulty? GetDifficultyByName(string name);
    }
}
