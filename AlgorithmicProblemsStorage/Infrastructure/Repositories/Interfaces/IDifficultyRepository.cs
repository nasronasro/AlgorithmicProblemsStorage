
using AlgorithmicProblemsStorage.Domain.Entities;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces
{
    public interface IDifficultyRepository
    {
        Difficulty? GetDifficultyByName(string name);
        Dictionary<int, String> GetAllDifficulties();
    }
}
