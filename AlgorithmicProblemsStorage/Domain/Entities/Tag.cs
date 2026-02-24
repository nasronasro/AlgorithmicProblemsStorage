using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicProblemsStorage.Domain.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        ICollection<Algorithm> algorithms { get; set; }
    }
}
