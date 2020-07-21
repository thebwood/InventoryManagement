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

        #region Private Variables

        private MoviesService _service;
        private List<MoviesModel> _movies;
        #endregion

        #region Constructor

        public Movie(MoviesService service)
        {
            _service = service;
        }

        #endregion


        #region Blazor Events

        protected override async Task OnInitializedAsync()
        {
            //_movies = await _service.GetMovies();
        }


        #endregion

    }
}
