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
    public class DocumentTagListRequest : IRequest<List<DocumentTagListResponse>>
    {
    }

    public class DocumentTagListHandler : BaseHandler, IRequestHandler<DocumentTagListRequest, List<DocumentTagListResponse>>
    {
        private readonly IDocumentTagService _documentTagService;

        public DocumentTagListHandler(IDocumentTagService documentTagService, IMapper mapper)
            : base(mapper)
        {
            _documentTagService = documentTagService ?? throw new System.ArgumentNullException(nameof(documentTagService));
        }

        public async Task<List<DocumentTagListResponse>> Handle(DocumentTagListRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<DocumentTagListResponse>>(await _documentTagService.GetAll());
        }
    }

    internal class DocumentTagProfile : Profile
    {
        public DocumentTagProfile()
        {
            CreateMap<DocumentTag, DocumentTagListResponse>();
        }
    }
}