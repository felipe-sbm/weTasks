using weTasks.Models;

namespace weTasks.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> SearchAllUsers();

        Task<UserModel> SearchUserById(int id);

        Task<UserModel> AddUser(UserModel User);
        Task<UserModel> UpdateUser(UserModel User, int id);

        Task<bool> DeleteUser(int id);
    }
}
