using System;
using AlgorithmicProblemsStorage.Application.Dtos;
using AlgorithmicProblemsStorage.Domain.Entities;

namespace AlgorithmicProblemsStorage.Application.Services.Interfaces
{
    public interface IAlgorithmServices
    {
        void AddAlgorithm(Algorithm algo);
        List<AlgoDisplayDto> GetAlgorithms();
    }
}
