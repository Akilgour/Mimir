using Microsoft.AspNetCore.Components;
using Mimir.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mimir.Client.Pages
{
    public class DocumentTagAdminBase : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        public List<DocumentTagListResponse> DocumentTags { get; set; }

        protected override async Task OnInitializedAsync()
        {
            DocumentTags = await Http.GetJsonAsync<List<DocumentTagListResponse>>("api/DocumentTag");
        }
    }
}
