using kvolikapi.Model;
using Microsoft.AspNetCore.Mvc;

namespace kvolikapi.Interfaces
{
    public interface IGenreService
    {
        Task<List<Genres>> GetAllUGenresAsync();
        Task<Genres> GetGenreByIdAsync(int id);
        Task<bool> CreateGenreAsync(Genres genres);
        Task<bool> UpdateUGenreAsync(Genres genres);
        Task<bool> DeleteGenreAsync(int id);
    }
}
