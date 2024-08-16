using Microsoft.EntityFrameworkCore;
using weTasks.Data;
using weTasks.Models;
using weTasks.Repositories.Interfaces;

namespace weTasks.Repositories
{
    public class UserRepositorie : IUserRepository
    {
        private readonly SystemTasksDBContext _dbContext;
        public UserRepositorie(SystemTasksDBContext systemTasksDBContext)
        {
            _dbContext = systemTasksDBContext;
        }
        public async Task<UserModel> SearchUserById(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<UserModel>> SearchAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }
        public async Task<UserModel> AddUser(UserModel User)
        {
            _dbContext.Users.Add(User);
            _dbContext.SaveChanges();

            return User;
        }
        public async Task<UserModel> UpdateUser(UserModel User, int id)
        {
            UserModel userById = await SearchUserById(id);
            if (userById == null)
            {
                throw new Exception($"The user by ID: {id} don't exist in database!");
            }
            userById.Name = User.Name;
            userById.Email = User.Email;

            _dbContext.Users.Update(userById);
            await _dbContext.SaveChangesAsync();

            return userById;
        }
        public async Task<bool> DeleteUser(int id)
        {
            UserModel userById = await SearchUserById(id);
            if (userById == null)
            {
                throw new Exception($"The user by ID: {id} don't exist in database!");
            }

            _dbContext.Users.Remove(userById);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
