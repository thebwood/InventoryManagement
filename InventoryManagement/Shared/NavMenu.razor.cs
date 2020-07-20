using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Shared
{
    public partial class NavMenu : ComponentBase
    {
        [Parameter]
        public EventCallback OnNavClicked { get; set; }

    }
}
