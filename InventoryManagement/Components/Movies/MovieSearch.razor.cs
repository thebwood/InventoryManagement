
using InventoryManagement.Models.Movies;
using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;

namespace InventoryManagement.Components.Movies
{
    public partial class MovieSearch : CommonMovieFunctions
    {
        private MovieSearchModel searchModel = new MovieSearchModel();

        [Parameter]
        public EventCallback<MovieSearchModel> OnSearchMovies { get; set; }

        private void SearchMovie()
        {
            if(OnSearchMovies.HasDelegate)
            {
                OnSearchMovies.InvokeAsync(searchModel);
            }
        }
        private void ResetMovieSearch()
        {
            searchModel = new MovieSearchModel();
        }
    }
}
