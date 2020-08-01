using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace InventoryManagement.Shared.BaseClasses
{
    public class CommonComponent : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        private IJSRuntime _jScript { get; set; }

        public async void ConsoleInfo<T>(T item)
        {
            await _jScript.InvokeVoidAsync("console.info", item);
        }

    }
}
