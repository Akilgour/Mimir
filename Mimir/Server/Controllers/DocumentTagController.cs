using Microsoft.AspNetCore.Mvc;
using Mimir.Server.Manager.Interface;
using System.Threading.Tasks;

namespace Mimir.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTagController : ControllerBase
    {
        private readonly IDocumentTagManager _documentTagManager;

        public DocumentTagController(IDocumentTagManager documentTagManager)
        {
            _documentTagManager = documentTagManager ?? throw new System.ArgumentNullException(nameof(documentTagManager));
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _documentTagManager.GetAll();
            return Ok(result);
        }
    }
}