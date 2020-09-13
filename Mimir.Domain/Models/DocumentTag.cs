namespace Mimir.Domain.Models
{
    public class DocumentTag : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Archived { get; set; }
    }
}