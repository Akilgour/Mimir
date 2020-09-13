using System;

namespace Mimir.Shared.Models
{
    public class DocumentTagDisplay
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Archived { get; set; }
    }
}