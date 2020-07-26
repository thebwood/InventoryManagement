using InventoryManagement.Models.Games;
using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Pages.Games
{
    public partial class Game : CommonGameFunctions
    {

        #region Private Variables
        private GamesModel _game = new GamesModel();
        private List<GameRatingsModel> _gameRatings = new List<GameRatingsModel>();

        private Task<GamesModel> _gameTask;
        private Task<List<GameRatingsModel>> _gameRatingsTask;

        #endregion

        #region Parameters
        [Parameter]
        public long GameId { get; set; }

        #endregion

        #region Blazor Events

        protected override void OnInitialized()
        {
            if (GameId > 0)
            {
                _gameTask = this.Service.GetGame(GameId);
            }
            _gameRatingsTask = this.Service.GetGameRatings();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {

                if (GameId > 0)
                {
                    await Task.WhenAll(_gameTask, _gameRatingsTask);
                    _game = _gameTask.Result;
                }
                else
                {
                    await Task.WhenAll(_gameRatingsTask);
                }

                _gameRatings = _gameRatingsTask.Result;
                this.StateHasChanged();
            }
        }

        #endregion

        #region Events

        private async Task SaveGameAsync()
        {

            var messages = await this.Service.SaveGame(_game);
            if (messages.Count() == 0)
            {
                this.NavigationManager.NavigateTo("games");
            }
        }

        private void CancelGameSave()
        {
            this.NavigationManager.NavigateTo("games");
        }
        #endregion
    }
}
