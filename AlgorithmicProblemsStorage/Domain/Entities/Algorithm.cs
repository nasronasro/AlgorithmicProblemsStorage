using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicProblemsStorage.Domain.Entities
{
    public class Algorithm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Code { get; set; }
        public DateOnly CreatedAt { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public int DifficultyId { get; set; }
        public int PlatformId { get; set; }
    }
}
