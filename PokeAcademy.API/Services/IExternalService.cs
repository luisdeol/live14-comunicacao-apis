using PokeAcademy.API.Controllers;
using Refit;

namespace PokeAcademy.API.Services
{
    public interface IExternalService
    {
        [Post("/api/random")]
        [Headers("X-LuisDevBlog: https://luisdev.com.br")]
        Task<ExternalResponse> GetData(Ping ping, [Header("Authorization")] string token);
    }
}
