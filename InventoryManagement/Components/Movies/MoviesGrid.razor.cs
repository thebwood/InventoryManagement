using InventoryManagement.Models.Movies;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Components.Movies
{
    public partial class MoviesGrid : ComponentBase
    {
        #region Parameters

        [Parameter]
        public List<MoviesModel> Models { get; set; }
        #endregion
    }
}
