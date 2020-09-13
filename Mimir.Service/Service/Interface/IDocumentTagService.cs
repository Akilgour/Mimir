using Mimir.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mimir.Service.Service.Interface
{
    public interface IDocumentTagService
    {
        Task<List<DocumentTag>> GetAll();
    }
}