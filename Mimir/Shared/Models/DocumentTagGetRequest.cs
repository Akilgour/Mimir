using MediatR;
using System;

namespace Mimir.Shared.Models
{
    public class DocumentTagGetRequest : IRequest<DocumentTagGetResponse>
    {
        public DocumentTagGetRequest(Guid documentTagId)
        {
            DocumentTagId = documentTagId;
        }

        public Guid DocumentTagId { get; private set; }
    }
}