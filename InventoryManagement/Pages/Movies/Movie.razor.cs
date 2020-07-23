using InventoryManagement.Models.Movies;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InventoryManagement.Pages.Movies
{
    public partial class Movie : ComponentBase
    {
        #region Dependency Injection
        [Inject]
        private MoviesService _service { get; set; }
        [Inject]
        private NavigationManager _navigationManager { get; set; }
        #endregion

        #region Private Variables
        private MoviesModel _movie = new MoviesModel();
        #endregion

        #region Parameters
        [Parameter]
        public int MovieId { get; set; }

        #endregion

        #region Blazor Events

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("MovieId");
            Console.WriteLine(MovieId);
            _movie = await _service.GetMovie(MovieId);
        }

        #endregion

        #region Events

        private async Task SaveMovieAsync()
        {

            var messages = await _service.SaveMovie(_movie);
            if(messages.Count() == 0)
            {
                _navigationManager.NavigateTo("movies");
            }
        }
        #endregion
    }
}
