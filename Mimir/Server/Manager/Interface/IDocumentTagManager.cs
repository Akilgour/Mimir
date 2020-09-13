using Mimir.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mimir.Server.Manager.Interface
{
    public interface IDocumentTagManager
    {
        Task<List<DocumentTagDisplay>> GetAll();
    }
}