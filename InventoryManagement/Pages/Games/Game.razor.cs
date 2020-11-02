using InventoryManagement.Models.Games;
using InventoryManagement.Shared.BaseClasses;
using InventoryManagement.StateManagement;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Pages.Games
{
    public partial class Game : CommonGameFunctions
    {

        #region Private Variables

        private EditContext _editContext;
        private GameDetailState _gameDetailStateManagement;

        private GamesModel _game = new GamesModel();
        private List<GameRatingsModel> _gameRatings = new List<GameRatingsModel>();

        #endregion

        #region Parameters
        [Parameter]
        public long GameId { get; set; }

        #endregion

        #region Blazor Events

        protected override async Task OnInitializedAsync()
        {
            _gameDetailStateManagement = new GameDetailState(Service);
            _gameDetailStateManagement.HandleGameLoaded += GameLoaded;
            _gameDetailStateManagement.HandleRatingsLoaded += RatingsLoaded;
            _gameDetailStateManagement.OnGameSavedSuccessfully += OnSaved;
            if (GameId > 0)
            {
                await _gameDetailStateManagement.LoadGame(GameId);
            }
            else
            {
                _game = new GamesModel();
                _editContext = new EditContext(_game);
            }
            await _gameDetailStateManagement.LoadRatings();
        }

        protected void Dispose()
        {
            _gameDetailStateManagement.HandleGameLoaded -= GameLoaded;
            _gameDetailStateManagement.HandleRatingsLoaded -= RatingsLoaded;
            _gameDetailStateManagement.OnGameSavedSuccessfully -= OnSaved;
        }

        private void RatingsLoaded(List<GameRatingsModel> ratings)
        {
            _gameRatings = ratings;
            StateHasChanged();
        }

        private void GameLoaded(GamesModel game)
        {
            _game = game;
            _editContext = new EditContext(_game);
            StateHasChanged();
        }


        #endregion

        #region Events

        private async Task SaveGame()
        {
            if (_editContext.Validate())
            {
                await _gameDetailStateManagement.SaveGame(_game);
            }
        }


        private void OnSaved()
        {
            this.NavigationManager.NavigateTo("games");
        }

        private void CancelSave()
        {
            this.NavigationManager.NavigateTo("games");
        }
        #endregion
    }
}
