using MediatR;
using Microsoft.AspNetCore.Mvc;
using Mimir.Server.Endpoint.DocumentTagEndpoint;
using Mimir.Shared.Models;
using System;
using System.Threading.Tasks;

namespace Mimir.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTagController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DocumentTagController(IMediator mediator)
        {
            _mediator = mediator ?? throw new System.ArgumentNullException(nameof(mediator));
        }

        [HttpGet("/api/DocumentTag")]
        public async Task<ActionResult> Get()
        {
            var result = await _mediator.Send(new DocumentTagListRequest());
            return Ok(result);
        }

        [HttpGet("/api/DocumentTag/{documentTagId}")]
        public async Task<ActionResult> Get(Guid documentTagId)
        {
            var result = await _mediator.Send(new DocumentTagGetRequest(documentTagId));
            return Ok(result);
        }

        [HttpPut("/api/DocumentTag")]
        public async Task<ActionResult> Update(DocumentTagUpdateRequest request)
        {
            var result = (DocumentTagUpdateResponse)await _mediator.Send(request);
            if (!result.FoundInRepository)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }

        }
    }
}