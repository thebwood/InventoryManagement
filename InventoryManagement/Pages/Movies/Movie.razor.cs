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
        public MoviesService _service = new MoviesService();

        #endregion

        #region Private Variables
        private MoviesModel _movie;
        #endregion

        #region Parameters
        [Parameter]
        public int movieId { get; set; }

        #endregion

        #region Blazor Events

        protected override async Task OnInitializedAsync()
        {
            _movie = await _service.GetMovie(movieId);
            if (_movie == null)
                _movie = new MoviesModel();

        }


        #endregion

    }
}
