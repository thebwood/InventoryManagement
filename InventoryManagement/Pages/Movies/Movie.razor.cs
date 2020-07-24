using InventoryManagement.Models.Movies;
using InventoryManagement.Services;
using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Pages.Movies
{
    public partial class Movie : CommonMovie
    {

        #region Private Variables
        private MoviesModel _movie = new MoviesModel();
        #endregion

        #region Parameters
        [Parameter]
        public long MovieId { get; set; }

        #endregion

        #region Blazor Events

        protected override async Task OnInitializedAsync()
        {
            _movie = await this.Service.GetMovie(MovieId);
        }

        #endregion

        #region Events

        private async Task SaveMovieAsync()
        {

            var messages = await this.Service.SaveMovie(_movie);
            if(messages.Count() == 0)
            {
                this.NavigationManager.NavigateTo("movies");
            }
        }
        #endregion
    }
}
