using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.BusinessModels.User;
using UPS.Framework.Models;

namespace UPS.Abstract.Services
{
    public interface IUserService
    {
        /// <summary>
        /// Add new user.
        /// </summary>
        /// <param name="registerUser"></param>
        /// <returns></returns>
        Task<UserModel> AddAsync(RegisterUserModel registerUser);

        /// <summary>
        /// Update the user.
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="registerUser"></param>
        /// <returns></returns>
        Task<UserModel> UpdateAsync(long UserId,RegisterUserModel registerUser);

        /// <summary>
        /// Get the user.
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        Task<UserModel> GetAsync(long UserId);

        /// <summary>
        /// Delete the User
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        Task DeleteAsync(long UserId);

        /// <summary>
        /// Get user list.
        /// </summary>
        /// <param name="userQuery"></param>
        /// <returns></returns>
        Task<PagedResult<UserModel>> GetAsync(UserQueryModel userQuery);
    }
}
