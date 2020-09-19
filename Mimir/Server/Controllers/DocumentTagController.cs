using MediatR;
using Microsoft.AspNetCore.Mvc;
using Mimir.Server.Endpoint.DocumentTagEndpoint;
using Mimir.Server.Manager.Interface;
using System.Threading.Tasks;

namespace Mimir.Server.Controllers
{
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
            var result = await _mediator.Send(new DocumentTagGetRequest());
            return Ok(result);
        }
    }
}