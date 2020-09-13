using Microsoft.EntityFrameworkCore;
using Mimir.Data.Context;
using Mimir.Data.Repositorys.Interface;
using Mimir.Domain.Models;
using Polly;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mimir.Data.Repositorys
{
    public class DocumentTagRepository : DataManager<DocumentTag, MirmirContext>, IDocumentTagRepository
    {
        public DocumentTagRepository(MirmirContext context, IAsyncPolicy retryPolicy)
          : base(context, retryPolicy)
        {
        }

        public async Task<List<DocumentTag>> GetAll()
        {
            var result = new List<DocumentTag>();
            await _retryPolicy.ExecuteAsync(async () =>
            {
                result = await context.DocumentTags.OrderBy(x => x.Name).ToListAsync();
            });
            return result;
        }
    }
}