using MediatR;
using Mimir.Server.Manager.Interface;
using Mimir.Shared.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mimir.Server.Endpoint.DocumentTagEndpoint
{
    public class DocumentTagGetRequest : IRequest<List<DocumentTagGetResponse>>
    {
    }

    public class DocumentTagGetHandler : IRequestHandler<DocumentTagGetRequest, List<DocumentTagGetResponse>>
    {
        private readonly IDocumentTagManager _documentTagManager;

        public DocumentTagGetHandler(IDocumentTagManager documentTagManager)
        {
            _documentTagManager = documentTagManager ?? throw new System.ArgumentNullException(nameof(documentTagManager));
        }

        public async Task<List<DocumentTagGetResponse>> Handle(DocumentTagGetRequest request, CancellationToken cancellationToken)
        {
            return await _documentTagManager.GetAll();
        }
    }
}