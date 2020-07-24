using InventoryManagement.Models.Games;
using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace InventoryManagement.Components.Games
{
    public partial class GamesGrid : CommonGame
    {
        #region Parameters
        
        [Parameter]
        public List<GamesModel> Models { get; set; }
        #endregion

    }
}
