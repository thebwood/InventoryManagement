using InventoryManagement.Models.Movies;
using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Pages.Movies
{
    public partial class Movie : CommonMovieFunctions
    {

        #region Private Variables
        private MoviesModel _movie = new MoviesModel();
        private List<MovieRatingsModel> _movieRatings = new List<MovieRatingsModel>();

        private Task<MoviesModel> _movieTask;
        private Task<List<MovieRatingsModel>> _movieRatingsTask;

        #endregion

        #region Parameters
        [Parameter]
        public long MovieId { get; set; } = 0;

        #endregion

        #region Blazor Events

        protected override void OnInitialized()
        {
            if(MovieId > 0)
            {
                _movieTask = this.Service.GetMovie(MovieId);
            }
            _movieRatingsTask = this.Service.GetMovieRatings();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender)
            {

                if (MovieId > 0)
                {
                    await Task.WhenAll(_movieTask, _movieRatingsTask);
                    _movie = _movieTask.Result;
                }
                else
                {
                    await Task.WhenAll(_movieRatingsTask);
                }

                _movieRatings = _movieRatingsTask.Result;
                this.StateHasChanged();
            }
        }

        #endregion

        #region Events

        private async Task SaveMovie()
        {

            var messages = await this.Service.SaveMovie(_movie);
            if(messages.Count() == 0)
            {
                this.NavigationManager.NavigateTo("movies");
            }
        }

        private void CancelSave()
        {
            this.NavigationManager.NavigateTo("movies");
        }
        #endregion
    }
}
