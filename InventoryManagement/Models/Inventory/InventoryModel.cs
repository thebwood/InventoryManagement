using InventoryManagement.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Inventory
{
    public class InventoryModel
    {

        public string CollectionName { get; set; }
        public PeopleModel Owner { get; set; }
        public List<InventoryItemModel> Items { get; set; }
    }
}
