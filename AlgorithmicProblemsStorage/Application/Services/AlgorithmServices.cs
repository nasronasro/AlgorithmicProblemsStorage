
using AlgorithmicProblemsStorage.Application.Services.Interfaces;
using AlgorithmicProblemsStorage.Domain.Entities;
using AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces;
using AlgorithmicProblemsStorage.Application.Dtos;
using AlgorithmicProblemsStorage.Application.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace AlgorithmicProblemsStorage.Application.Services
{
    internal class AlgorithmServices : IAlgorithmServices
    {
        private readonly IAlgorithmRepository _algoRepository;
        private readonly ITagRepository _tagRepository;
        private readonly IDifficultyRepository _difficultyRepository;
        private readonly IPlatformeRepository _platformRepository;
        public AlgorithmServices(IServiceProvider sp)
        {
            _algoRepository = sp.GetRequiredService<IAlgorithmRepository>();
            _tagRepository = sp.GetRequiredService<ITagRepository>();
            _difficultyRepository = sp.GetRequiredService<IDifficultyRepository>();
            _platformRepository = sp.GetRequiredService<IPlatformeRepository>();
        }
        public void AddAlgorithm(Algorithm algo)
        {
            int algoId = _algoRepository.AddAlgo(algo);
            algo.Id = algoId;

            List<Tag> tagsDb = _tagRepository.ListTags();
            foreach(var tag in algo.Tags)
            {
                if (!tagsDb.Any(t => string.Equals(t.Name, tag.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    int tagId = _tagRepository.AddTag(tag);
                    tag.Id = tagId;

                }
                else
                {
                    tag.Id = _tagRepository.GetTagIdByName(tag.Name);
                }

                _algoRepository.AddTagAlgo(algo, tag);
            }

        }

        public List<AlgoDisplayDto> GetAlgorithms()
        {
            List<AlgoDisplayDto> algosDisplay = new();
            Dictionary<int, string> DifficultyList = _difficultyRepository.GetAllDifficulties();
            Dictionary<int, string> PlatformeList = _platformRepository.GetAllPlatformes();
            foreach(var algo in _algoRepository.GetAllAlgorithms())
            {
                var algoDisplay = AlgorithmeMappers.MapAlgorithmToAlgoDisplayDto(algo);
                string? diffStr, platformStr;
                DifficultyList.TryGetValue(algo.DifficultyId, out diffStr);
                PlatformeList.TryGetValue(algo.PlatformId, out platformStr);
                algoDisplay.Difficulty = diffStr;
                algoDisplay.Platforme = platformStr;
                algosDisplay.Add(algoDisplay);
            }
            return algosDisplay;
        }

    }
}
