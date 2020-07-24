using Microsoft.AspNetCore.Components;

namespace InventoryManagement.Shared.BaseClasses
{
    public class CommonComponent : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

    }
}
