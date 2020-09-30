using Microsoft.AspNetCore.Components;
using Mimir.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Mimir.Client.Pages
{
    public class DocumentTagEditBase : ComponentBase
    {
        [Parameter]
        public string DocumentTagId { get; set; }
      
        [Inject]
        public HttpClient Http { get; set; }

        public DocumentTagGetResponse DocumentTag { get; set; }

        protected override async Task OnInitializedAsync()
        {
            DocumentTag = await Http.GetJsonAsync<DocumentTagGetResponse>($"api/DocumentTag/{DocumentTagId}");
        }

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        protected async Task HandleValidSubmit()
        {
            await Http.PutAsJsonAsync($"api/DocumentTag", DocumentTag);
            StatusClass = "alert-success";
            Message = "Comment successfully.";
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
        }
    }
}