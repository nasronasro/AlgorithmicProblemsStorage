using AlgorithmicProblemsStorage.Domain.Entities;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories
{
    public interface IAlgorithmRepository
    {
        void AddAlgo(Algorithm algo);
        void AddTagAlgo(Algorithm algo, Tag tag);
    }
}