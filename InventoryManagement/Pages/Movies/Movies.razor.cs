using InventoryManagement.Models.Movies;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Pages.Movies
{
    public partial class Movies : ComponentBase
    {
        #region Dependency Injection
        public MoviesService _service = new MoviesService();

        #endregion

        #region Private Variables
        private List<MoviesModel> _movies;
        #endregion



        #region Blazor Events

        protected override async Task OnInitializedAsync()
        {
            _movies = await _service.GetMovies();
        }


        #endregion
    }
}
