using kvolikapi.Model;

namespace kvolikapi.Interfaces
{
    public interface IUserService
    {
        Task<List<Users>> GetAllUsersAsync();
        Task<Users> GetUserByIdAsync(int id);
        Task<bool> CreateUserAsync(Users user);
        Task<bool> UpdateUserAsync(Users user);
        Task<bool> DeleteUserAsync(int id);
        Task<Users> AuthenticationAsync(string email, string password);
    }
}
