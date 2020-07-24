using InventoryManagement.Models.Movies;
using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace InventoryManagement.Components.Movies
{
    public partial class MoviesGrid : CommonMovieFunctions
    {
        #region Parameters

        [Parameter]
        public List<MoviesModel> Models { get; set; }
        #endregion


        public void EditMovie(long movieId)
        {
            this.NavigationManager.NavigateTo("movies/" + movieId.ToString());

        }
    }
}
