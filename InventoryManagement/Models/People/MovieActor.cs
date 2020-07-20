using InventoryManagement.Models.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.People
{
    public class MovieActor
    {
        public MoviesModel Movie { get; set; }
        public ActorModel Actor { get; set; }
    }
}
