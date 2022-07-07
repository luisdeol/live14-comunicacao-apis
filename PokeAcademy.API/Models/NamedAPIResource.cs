using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeAcademy.API.Models
{
     public class NamedAPIResource
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class PokemonListItemViewModel {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}