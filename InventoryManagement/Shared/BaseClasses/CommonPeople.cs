using InventoryManagement.Services;
using Microsoft.AspNetCore.Components;

namespace InventoryManagement.Shared.BaseClasses
{
    public class CommonPeople : CommonComponent
    {
        #region Dependency Injection

        [Inject]
        public PeopleService Service { get; set; }

        #endregion
    }
}
