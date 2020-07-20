using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Movies
{
    public class MoviesModel
    {
        public long Id { get; set; }
        public Guid Identifier { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public int ReleaseDate { get; set; }
        public MovieRatingsModel Rating { get; set; }
    }
}
