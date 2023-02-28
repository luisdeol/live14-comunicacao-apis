using PokeAcademy.API.Models;
using Refit;

namespace PokeAcademy.API.Services
{
    public interface IPokeService
    {
        [Get("/pokemon")]
        Task<NamedAPIResourceList> GetAll(int limit);

        [Get("/pokemon/{id}")]
        Task<PokemonData> GetById(int id);
    }
}
