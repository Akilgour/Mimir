using Mimir.Data.Repositorys.Interface;
using Mimir.Domain.Models;
using Mimir.Service.Service.Interface;
using Mimir.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimir.Service.Service
{
    public class DocumentTagService : IDocumentTagService
    {
        private readonly IDocumentTagRepository _documentTagRepository;

        public DocumentTagService(IDocumentTagRepository documentTagRepository)
        {
            _documentTagRepository = documentTagRepository;
        }

        public async Task<DocumentTag> Get(Guid documentTagId)
        {
            return await _documentTagRepository.GetById(documentTagId);
        }

        public async Task<List<DocumentTag>> GetAll()
        {
            return await _documentTagRepository.GetAll();
        }

        public async Task<DocumentTag> Update(DocumentTag documentTag)
        {
            return await _documentTagRepository.Update(documentTag);
        }
    }
}
