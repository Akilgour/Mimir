using Microsoft.AspNetCore.Components;
using Mimir.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

 

namespace Mimir.Client.Pages
{
    public class DocumentTagAdminBase : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        public List<DocumentTagDisplay> DocumentTags { get; set; }

        protected override async Task OnInitializedAsync()
        {
            DocumentTags = await Http.GetJsonAsync<List<DocumentTagDisplay>>("api/DocumentTag");
        }
    }
}
