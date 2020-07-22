using InventoryManagement.Models.Games;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Components.Games
{
    public partial class GamesGrid : ComponentBase
    {
        #region Parameters
        
        [Parameter]
        public List<GamesModel> Models { get; set; }
        #endregion

    }
}
