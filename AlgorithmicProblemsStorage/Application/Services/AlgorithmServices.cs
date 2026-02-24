using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AlgorithmicProblemsStorage.Application.Services.Interfaces;
using AlgorithmicProblemsStorage.Domain.Entities;
using AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces;

namespace AlgorithmicProblemsStorage.Application.Services
{
    internal class AlgorithmServices : IAlgorithmServices
    {
        IAlgorithmRepository _algoRepository;
        ITagRepository _tagRepository;
        public AlgorithmServices(IAlgorithmRepository algoRepository, ITagRepository tagRepository)
        {
            _algoRepository = algoRepository;
            _tagRepository = tagRepository;
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
    }
}
