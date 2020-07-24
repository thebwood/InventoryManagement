using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;

namespace InventoryManagement.Pages.Games
{
    public partial class Game : CommonGame
    {
        [Parameter]
        public long GameId { get; set; }
    }
}
