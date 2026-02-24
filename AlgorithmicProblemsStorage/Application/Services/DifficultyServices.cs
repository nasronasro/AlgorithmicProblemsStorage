using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmicProblemsStorage.Application.Services.Interfaces;
using AlgorithmicProblemsStorage.Domain.Entities;
using AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces;

namespace AlgorithmicProblemsStorage.Application.Services
{
    public class DifficultyServices : IDifficultyServices
    {
        private readonly IDifficultyRepository _repository;

        public DifficultyServices(IDifficultyRepository repository)
        {
            _repository = repository;
        }
        public Difficulty? GetDifficultyByName(string name)
        {
           return _repository.GetDifficultyByName(name);
        }
    }
}
