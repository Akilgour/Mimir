using System;

namespace Mimir.Shared.Models
{
    public class DocumentTagGetResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Archived { get; set; }
    }
}