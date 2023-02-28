namespace PokeAcademy.API.Models
{
    public class NamedAPIResourceList
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public NamedAPIResource[] Results { get; set; }

        public PokemonListViewModel MapToViewModel()
        {
            return new PokemonListViewModel
            {
                Count = Count,
                Pokemons = Results.Select(p => {
                    var lastSegment = new Uri(p.Url).Segments.Last(); // 73/
                    var id = lastSegment.Remove(lastSegment.Length - 1);

                    return new PokemonListItemViewModel { Name = p.Name, Id = int.Parse(id) };
                })
            };
        }
    }

    public class PokemonListViewModel {
        public int Count { get; set; }
        public IEnumerable<PokemonListItemViewModel> Pokemons { get; set; }
    }
}