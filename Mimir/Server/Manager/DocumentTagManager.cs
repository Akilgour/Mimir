using AutoMapper;
using Mimir.Server.Manager.Interface;
using Mimir.Service.Service.Interface;
using Mimir.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mimir.Server.Manager
{
    public class DocumentTagManager : BaseManager, IDocumentTagManager
    {
        private readonly IDocumentTagService _documentTagService;

        public DocumentTagManager(IDocumentTagService documentTagService, IMapper mapper)
            : base(mapper)
        {
            _documentTagService = documentTagService ?? throw new System.ArgumentNullException(nameof(documentTagService));
        }

        public async Task<List<DocumentTagDisplay>> GetAll()
        {
            return _mapper.Map<List<DocumentTagDisplay>>(await _documentTagService.GetAll());
        }
    }
}