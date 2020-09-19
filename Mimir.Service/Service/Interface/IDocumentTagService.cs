using Mimir.Domain.Models;
using Mimir.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mimir.Service.Service.Interface
{
    public interface IDocumentTagService
    {
        Task<List<DocumentTag>> GetAll();
        Task<DocumentTag> Get(DocumentTagGetRequest request);
    }
}