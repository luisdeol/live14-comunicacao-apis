using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeAcademy.API.Models
{
    public class NamedAPIResourceList
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public NamedAPIResource[] Results { get; set; }
    }

    public class PokemonListViewModel {
        public int Count { get; set; }
        public IEnumerable<PokemonListItemViewModel> Pokemons { get; set; }
    }
}