using InventoryManagement.Models.Movies;
using InventoryManagement.Services;
using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Pages.Movies
{
    public partial class Movies : CommonMovieFunctions
    {

        #region Private Variables
        private List<MoviesModel> _movies;
        private Task<List<MoviesModel>> _moviesTask;
        #endregion



        #region Blazor Events

        protected override void OnInitialized()
        {
            _moviesTask = this.Service.GetMovies();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender)
            {
                await Task.WhenAll(_moviesTask);
                _movies = _moviesTask.Result;

                if (_movies == null)
                    _movies = new List<MoviesModel>();
            }
        }

        #endregion

        #region Events

        private void AddMovie()
        {
            this.NavigationManager.NavigateTo("movies/0");

        }
        #endregion
    }
}
