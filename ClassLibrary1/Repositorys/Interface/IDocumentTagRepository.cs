using Mimir.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mimir.Data.Repositorys.Interface
{
    public interface IDocumentTagRepository
    {
        Task<List<DocumentTag>> GetAll();
    }
}