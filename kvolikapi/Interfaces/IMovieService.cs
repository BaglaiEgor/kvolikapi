using kvolikapi.Model;
using kvolikapi.Requests;

namespace kvolikapi.Interfaces
{
    public interface IMovieService
    {
        Task<List<Movies>> GetAllMoviesAsync();
        Task<Movies> GetMovieByIdAsync(int id);
        Task<List<Movies>> GetMovieByTitleAsync(string title);
        Task<bool> CreateMovieAsync(Movies movie);
        Task<bool> UpdateMovieAsync(Movies movie);
        Task<bool> DeleteMovieAsync(int id);
    }
}
