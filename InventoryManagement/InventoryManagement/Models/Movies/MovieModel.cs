﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Movies
{
    public class MovieModel
    {
        public Guid Identifier { get; set; } = Guid.NewGuid();

    }
}
