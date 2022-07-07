using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokeAcademy.API.Models;
using Refit;

namespace PokeAcademy.API.Services
{
    public interface IPokeService
    {
        [Get("/pokemon")]
        Task<NamedAPIResourceList> GetAll(int limit);
        [Get("/pokemon/{id}")]
        Task<Root> GetById(int id);
    }
}