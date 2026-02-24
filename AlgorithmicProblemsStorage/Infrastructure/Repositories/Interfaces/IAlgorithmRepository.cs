using AlgorithmicProblemsStorage.Domain.Entities;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces
{
    public interface IAlgorithmRepository
    {
        int AddAlgo(Algorithm algo);
        void AddTagAlgo(Algorithm algo, Tag tag);
    }
}