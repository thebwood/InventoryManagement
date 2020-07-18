using InventoryManagement.Models.RefData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Games
{
    public class GameModel
    {
        public Guid Identifier { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<GameTypeModel> Types { get; set; }

    }
}
