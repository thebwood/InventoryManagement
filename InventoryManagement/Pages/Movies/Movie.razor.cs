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
        public MoviesService _service;

        #endregion

        #region Private Variables
        private MoviesModel _movie;
        #endregion



        #region Blazor Events

        protected override void OnInitialized()
        {
            //_movies = await _service.GetMovies();
        }


        #endregion

    }
}
