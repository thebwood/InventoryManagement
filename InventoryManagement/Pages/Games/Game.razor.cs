using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;

namespace InventoryManagement.Pages.Games
{
    public partial class Game : CommonGameFunctions
    {
        [Parameter]
        public long GameId { get; set; }
    }
}
