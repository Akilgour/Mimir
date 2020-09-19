using AutoMapper;
using MediatR;
using Mimir.Domain.Models;
using Mimir.Service.Service.Interface;
using Mimir.Shared.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mimir.Server.Endpoint.DocumentTagEndpoint
{
    public class DocumentTagGetRequest : IRequest<List<DocumentTagGetResponse>>
    {
    }

    public class DocumentTagGetHandler : BaseHandler, IRequestHandler<DocumentTagGetRequest, List<DocumentTagGetResponse>>
    {
        private readonly IDocumentTagService _documentTagService;

        public DocumentTagGetHandler(IDocumentTagService documentTagService, IMapper mapper)
            : base(mapper)
        {
            _documentTagService = documentTagService ?? throw new System.ArgumentNullException(nameof(documentTagService));
        }

        public async Task<List<DocumentTagGetResponse>> Handle(DocumentTagGetRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<DocumentTagGetResponse>>(await _documentTagService.GetAll());
        }
    }

    internal class DocumentTagProfile : Profile
    {
        public DocumentTagProfile()
        {
            CreateMap<DocumentTag, DocumentTagGetResponse>();
        }
    }
}