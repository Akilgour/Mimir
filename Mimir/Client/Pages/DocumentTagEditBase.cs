using Microsoft.AspNetCore.Components;

namespace Mimir.Client.Pages
{
    public class DocumentTagEditBase : ComponentBase
    {
        [Parameter]
        public string DocumentTagId { get; set; }

        protected override void OnInitialized()
        {
        }
    }
}