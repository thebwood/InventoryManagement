using InventoryManagement.Models.RefData;
using InventoryManagement.Models.RefData.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.StateManagement
{
    public class RefDataStateManagement
    {
        public List<GameTypesModel> GameTypes { get; private set; }
        public List<MovieGenresModel> MovieGenres { get; private set; }

        public event Action OnChange;

        public void SetGameTypes(List<GameTypesModel> gameTypes)
        {
            GameTypes = gameTypes;
            NotifyStateChanged();
        }

        public void SetMovieGenres(List<MovieGenresModel> movieGenres)
        {
            MovieGenres = movieGenres;
            NotifyStateChanged();
        }


        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
