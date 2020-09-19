using AutoMapper;
using MediatR;
using Mimir.Domain.Models;
using Mimir.Service.Service.Interface;
using Mimir.Shared.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Mimir.Server.Endpoint.DocumentTagEndpoint
{
    public class DocumentTagGetHandler : BaseHandler, IRequestHandler<DocumentTagGetRequest, DocumentTagGetResponse>
    {
        private readonly IDocumentTagService _documentTagService;

        public DocumentTagGetHandler(IDocumentTagService documentTagService, IMapper mapper)
            : base(mapper)
        {
            _documentTagService = documentTagService ?? throw new System.ArgumentNullException(nameof(documentTagService));
        }

        async Task<DocumentTagGetResponse> IRequestHandler<DocumentTagGetRequest, DocumentTagGetResponse>.Handle(DocumentTagGetRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<DocumentTagGetResponse>(await _documentTagService.Get(request));
        }
    }

    internal class DocumentTagGetProfile : Profile
    {
        public DocumentTagGetProfile()
        {
            CreateMap<DocumentTag, DocumentTagGetResponse>();
        }
    }
}