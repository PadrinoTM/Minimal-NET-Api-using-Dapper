using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IUserData
    {
        Task DeleteUser(int id);
        Task<UserModels> GetUser(int id);
        Task<IEnumerable<UserModels>> GetUsers();
        Task InsertUser(UserModels user);
        Task UpdateUser(UserModels user);
    }
}