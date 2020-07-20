using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Components.Games
{
    public partial class GamesGrid : ComponentBase
    {
        #region Parameters
        
        [Parameter]
        public List<string> Games { get; set; }
        #endregion
        private string _currentSelectedPerson = "noone";
        public class Person
        {
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }

            public Person(int id, string firstname, string lastname)
            {
                Id = id;
                Firstname = firstname;
                Lastname = lastname;
            }
        }

        Person[] people = new[]
                {
                new Person(1, "Gerda", "Mugwort"),
                new Person(2, "Mattalic", "Burrowes"),
                new Person(3, "Hal", "Smallburrow"),
            };

        void OnPersonDbClicked(object item)
        {
            var person = item as Person;
            if (person == null)
            {
                _currentSelectedPerson = "noone";
                return;
            }

            _currentSelectedPerson = $"{person.Firstname} {person.Lastname}";
        }

    }
}
