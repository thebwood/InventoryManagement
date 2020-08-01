using InventoryManagement.Models.Games;
using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace InventoryManagement.Components.Games
{
    public partial class GamesGrid : CommonGameFunctions
    {
        #region Parameters
        
        [Parameter]
        public List<GameSearchResultsModel> Models { get; set; }

        #endregion

        #region Events

        private void EditGame(long gameId)
        {
            this.NavigationManager.NavigateTo("games/" + gameId.ToString());
        }

        #endregion
    }
}
