using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmicProblemsStorage.Domain.Entities;

namespace AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces
{
    public interface ITagRepository
    {
        int AddTag(Tag tag);
        List<Tag> ListTags();
        int GetTagIdByName(string name);
    }
}
