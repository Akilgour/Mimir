using Mimir.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mimir.Data.Repositorys.Interface
{
    public interface IDocumentTagRepository : IRepository<DocumentTag>
    {
        Task<List<DocumentTag>> GetAll();
    }
}