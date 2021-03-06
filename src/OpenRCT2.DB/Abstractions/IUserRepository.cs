﻿using System.Threading.Tasks;
using OpenRCT2.DB.Models;

namespace OpenRCT2.DB.Abstractions
{
    public interface IUserRepository
    {
        Task<User[]> GetAll();
        Task<User> GetUserFromIdAsync(string id);
        Task<User> GetUserFromOpenRCT2orgIdAsync(int id);
        Task InsertUserAsync(User user);
        Task UpdateUserAsync(User user);
    }
}
