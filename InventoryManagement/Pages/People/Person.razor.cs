using InventoryManagement.Shared.BaseClasses;
using Microsoft.AspNetCore.Components;

namespace InventoryManagement.Pages.People
{
    public partial class Person : CommonPeople
    {
        [Parameter]
        public long PersonId { get; set; }
    }
}
