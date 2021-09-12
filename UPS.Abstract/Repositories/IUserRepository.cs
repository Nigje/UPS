using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UPS.BusinessModels.Entities;

namespace UPS.Abstract.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// Add new user.
        /// </summary>
        /// <param name="registerUser"></param>
        /// <returns></returns>
        Task<User> AddAsync(User user);

        /// <summary>
        /// Update the user.
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="registerUser"></param>
        /// <returns></returns>
        Task<User> UpdateAsync(User user);

        /// <summary>
        /// Get the user.
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        Task<User> GetAsync(long UserId);

        /// <summary>
        /// Delete the User
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        Task DeleteAsync(long UserId);

        /// <summary>
        /// Get users.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="orderProperty"></param>
        /// <param name="orderAsc"></param>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        Task<List<User>> WhereAsync(Expression<Func<User, bool>> criteria, Expression<Func<User, object>> orderProperty = null, bool orderAsc = false, int skip = 0, int take = int.MaxValue);

        /// <summary>
        /// Get the first user or null.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="orderProperty"></param>
        /// <param name="orderAsc"></param>
        /// <returns></returns>
        Task<User> FirstOrDefaultAsync(Expression<Func<User, bool>> criteria, Expression<Func<User, object>> orderProperty = null, bool orderAsc = true);

        /// <summary>
        /// Return the count of users.
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<int> CountAsync(Expression<Func<User, bool>> criteria);


    }
}
