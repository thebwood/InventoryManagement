using InventoryManagement.Models.Games;
using InventoryManagement.Shared.BaseClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryManagement.Pages.Games
{
    public partial class Games : CommonGameFunctions
    {
        #region Private Variables
        private List<GameSearchResultsModel> _games;
        #endregion



        #region Blazor Events

        protected override async Task OnInitializedAsync()
        {
            await HandleGameSearch(new GameSearchModel());
            if (_games == null)
                _games = new List<GameSearchResultsModel>();
        }
        #endregion

        #region Events

        private void AddGame()
        {
            this.NavigationManager.NavigateTo("games/0");

        }

        private async Task HandleGameSearch(GameSearchModel searchModel)
        {
            _games = await this.Service.SearchGames(searchModel);
        }


        #endregion

    }
}
