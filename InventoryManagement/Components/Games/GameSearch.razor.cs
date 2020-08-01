using InventoryManagement.Models.Games;
using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryManagement.Components.Games
{
    public partial class GameSearch : CommonGameFunctions
    {
        #region Private Variables
        private GameSearchModel _searchModel = new GameSearchModel();
        private List<GameRatingsModel> _gameRatings = new List<GameRatingsModel>();

        private Task<List<GameRatingsModel>> _gameRatingsTask;

        #endregion

        #region Parameters

        [Parameter]
        public EventCallback<GameSearchModel> OnSearchGames { get; set; }

        #endregion

        #region Blazor Events

        protected override void OnInitialized()
        {
            _gameRatingsTask = this.Service.GetGameRatings();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Task.WhenAll(_gameRatingsTask);
                _gameRatings = _gameRatingsTask.Result;

                this.StateHasChanged();
            }
        }
        #endregion


        #region Events

        private void SearchGame()
        {
            if (OnSearchGames.HasDelegate)
            {
                OnSearchGames.InvokeAsync(_searchModel);
            }
        }
        private void ResetSearch()
        {
            _searchModel = new GameSearchModel();
        }
        #endregion

    }
}
