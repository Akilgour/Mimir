using System;

namespace Mimir.Shared.Models
{
    public class DocumentTagUpdateResponse
    {
        public bool FoundInRepository { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}