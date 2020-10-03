using Mimir.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mimir.Service.Service.Interface
{
    public interface IDocumentTagService
    {
        Task<List<DocumentTag>> GetAll();

        Task<DocumentTag> Get(Guid documentTagId);
        Task<DocumentTag> Update(DocumentTag documentTag);
    }
}