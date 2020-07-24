using InventoryManagement.Models.Movies;
using InventoryManagement.Services;
using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Pages.Movies
{
    public partial class Movies : CommonMovie
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
    }
}
