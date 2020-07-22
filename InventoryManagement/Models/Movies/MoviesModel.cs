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
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int MovieRatingId { get; set; }
        public int? Hours { get; set; }
        public int? Minutes { get; set; }
        public MovieRatingsModel Rating { get; set; }
    }
}
