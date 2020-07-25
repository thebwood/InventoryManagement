using InventoryManagement.Models.Games;
using InventoryManagement.Shared.BaseClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryManagement.Pages.Games
{
    public partial class Games : CommonGameFunctions
    {
        #region Private Variables
        private List<GamesModel> _games;
        #endregion



        #region Blazor Events

        protected override async Task OnInitializedAsync()
        {
            _games = await this.Service.GetGames();
            if (_games == null)
                _games = new List<GamesModel>();
        }
        #endregion
    }
}
