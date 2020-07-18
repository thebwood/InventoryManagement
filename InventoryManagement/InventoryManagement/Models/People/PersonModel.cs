using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.People
{
    public class PersonModel
    {
        public Guid Identifier { get; set; } = Guid.NewGuid();
    }
}
