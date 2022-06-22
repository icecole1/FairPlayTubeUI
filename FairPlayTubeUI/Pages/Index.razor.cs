using Microsoft.AspNetCore.Components;

namespace FairPlayTubeUI.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject] public NavigationManager? Navigation { get; set; }

        private void WatchVideoAsync(int id)
        {
            Navigation?.NavigateTo($"/watch/{id}");
        }
    }
}
