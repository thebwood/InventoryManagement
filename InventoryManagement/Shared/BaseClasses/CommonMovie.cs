﻿using InventoryManagement.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Shared.BaseClasses
{
    public class CommonMovie : CommonComponent
    {
        #region Dependency Injection
        [Inject]
        public MoviesService Service { get; set; }
        #endregion

    }
}
