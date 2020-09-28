using AutoMapper;
using MediatR;
using Mimir.Domain.Models;
using Mimir.Service.Service.Interface;
using Mimir.Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mimir.Server.Endpoint.DocumentTagEndpoint
{

    public class DocumentTagUpdateHandler : BaseHandler, IRequestHandler<DocumentTagUpdateRequest, DocumentTagUpdateResponse>
    {
        private readonly IDocumentTagService _documentTagService;

        public DocumentTagUpdateHandler(IDocumentTagService documentTagService, IMapper mapper)
            : base(mapper)
        {
            _documentTagService = documentTagService ?? throw new System.ArgumentNullException(nameof(documentTagService));
        }

        public async Task<DocumentTagUpdateResponse> Handle(DocumentTagUpdateRequest request, CancellationToken cancellationToken)
        {
            var response = new DocumentTagUpdateResponse();
            var documentTag =  await _documentTagService.Get(request.Id);
            if(documentTag == null)
            {
                response.FoundInRepository = false;
            }
            else
            {
                _mapper.Map(request, documentTag);
                response = _mapper.Map<DocumentTagUpdateResponse>(await _documentTagService.Update(documentTag));
                response.FoundInRepository = true;
            }
            return response;
        }

        internal class DocumentTagUpdateProfile : Profile
        {
            public DocumentTagUpdateProfile()
            {
                //For the updateing from the item from repository with the item from the API request
                CreateMap<DocumentTagUpdateRequest, DocumentTag>();

                //For the response 
                CreateMap<DocumentTag, DocumentTagUpdateResponse>();
            }
        }
    }
}
