using Microsoft.AspNetCore.Components;

namespace FairPlayTubeUI.Pages.Components
{
    public partial class WatchVideo : ComponentBase
    {
        [Parameter] public string? Name { get; set; }
    }
}
