using MediatR;
using System;

namespace Mimir.Shared.Models
{
    public class DocumentTagUpdateRequest : IRequest<DocumentTagUpdateResponse>
    {
        public DocumentTagUpdateRequest()
        {
        }

        public DocumentTagUpdateRequest(DocumentTagGetResponse documentTag)
        {
            Id = documentTag.Id;
            Name = documentTag.Name;
            Description = documentTag.Description;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}