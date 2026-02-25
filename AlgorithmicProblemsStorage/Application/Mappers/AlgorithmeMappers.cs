using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmicProblemsStorage.Application.Dtos;
using AlgorithmicProblemsStorage.Domain.Entities;

namespace AlgorithmicProblemsStorage.Application.Mappers
{
    public static class AlgorithmeMappers
    {
        public static AlgoDisplayDto MapAlgorithmToAlgoDisplayDto(Algorithm entity)
        {
            return new AlgoDisplayDto
            {
                Title = entity.Title,
                Date = entity.CreatedAt,
                Link = entity.Link
            };
        }
    }
}
