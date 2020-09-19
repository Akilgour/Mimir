using MediatR;
using Microsoft.AspNetCore.Mvc;
using Mimir.Server.Manager.Interface;
using Mimir.Shared.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mimir.Server.Controllers
{
    public class GetRequest : IRequest<List<DocumentTagGetResponse>>
    {
    }

    public class GetHandler : IRequestHandler<GetRequest, List<DocumentTagGetResponse>>
    {
        private readonly IDocumentTagManager _documentTagManager;

        public GetHandler(IDocumentTagManager documentTagManager)
        {
            _documentTagManager = documentTagManager ?? throw new System.ArgumentNullException(nameof(documentTagManager));
        }

        public async Task<List<DocumentTagGetResponse>> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            return await _documentTagManager.GetAll();
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTagController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DocumentTagController(IDocumentTagManager documentTagManager, IMediator mediator)
        {
            _mediator = mediator ?? throw new System.ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _mediator.Send(new GetRequest());
            return Ok(result);
        }
    }
}