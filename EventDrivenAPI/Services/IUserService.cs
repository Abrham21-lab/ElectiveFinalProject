using EventDrivenAPI.Models;
using EventDrivenAPI.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventDrivenAPI.Services
{
    public interface IUserServices
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User?> GetUserByIdAsync(string id);
        Task<User?> GetUserByPhoneAsync(string phoneNumber);
        Task<bool> CreateUserAsync(CreateUser dto);
        Task<bool> DeleteUserAsync(string id);
    }
}