﻿using InventoryManagement.Models.Movies;
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
        #endregion



        #region Blazor Events

        protected override async Task OnInitializedAsync()
        {
            _movies = await this.Service.GetMovies();
            if (_movies == null)
                _movies = new List<MoviesModel>();
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
