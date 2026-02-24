
using AlgorithmicProblemsStorage.Application.Services.Interfaces;
using AlgorithmicProblemsStorage.Domain.Entities;
using AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces;

namespace AlgorithmicProblemsStorage.Application.Services
{
    public class PlatformeServices : IPlatformeServices
    {
        private readonly IPlatformeRepository _repository;
        public PlatformeServices(IPlatformeRepository repository)
        {
            _repository = repository;
        }
        public Platforme? GetPlatformByName(string name)
        {
            return _repository.GetPlatformeByName(name);
        }
    }
}
