using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UPS.Abstract.Repositories;
using UPS.BusinessModels.Entities;
using UPS.Framework.DI;
using UPS.Framework.Exceptions;

namespace UPS.DB.Repositories
{
    public class UserRepository : IUserRepository, ITransientLifetime
    {
        //************************************************************************************************************************************
        //Variables:
        private readonly AppDBContext _db;
        //************************************************************************************************************************************
        public UserRepository(AppDBContext db)
        {
            _db = db;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Add a user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> AddAsync(User user)
        {
            await _db.Users.AddAsync(user);
            await CommitAsync();
            return user;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Delete a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task DeleteAsync(long userId)
        {
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == userId);
            if (user == null)
                throw new UPSExceptionNotFound(message: $"UserId: {userId} Not Found",errorCode:"USER_NOT_FOUND");
            _db.Users.Remove(user);
            await _db.SaveChangesAsync();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Get a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<User> GetAsync(long userId)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.Id == userId);
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Update a user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> UpdateAsync(User user)
        {
            _db.Users.Update(user);
            await CommitAsync();
            return user;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Get user list.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="orderProperty"></param>
        /// <param name="orderAsc"></param>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        public async Task<List<User>> WhereAsync(Expression<Func<User, bool>> criteria, Expression<Func<User, object>> orderProperty = null, bool orderAsc = false, int skip = 0, int take = int.MaxValue)
        {
            IQueryable<User> query = _db.Users.AsQueryable<User>();
            if (orderProperty != null && orderAsc == true)
            {
                query = query.OrderBy(orderProperty);
            }
            else if (orderProperty != null && orderAsc == false)
            {
                query = query.OrderByDescending(orderProperty);
            }
            if (skip < 0)
                skip = 1;

            query = query.Where(criteria).Skip(skip).Take(take);

            return await query.ToListAsync();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Get the first user or null.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="orderProperty"></param>
        /// <param name="orderAsc"></param>
        /// <returns></returns>
        public async Task<User> FirstOrDefaultAsync(Expression<Func<User, bool>> criteria, Expression<Func<User, object>> orderProperty = null, bool orderAsc = false)
        {
            IQueryable<User> query = _db.Users.AsQueryable<User>();
            if (orderProperty != null && orderAsc == true)
            {
                query = query.OrderBy(orderProperty);
            }
            else if (orderProperty != null && orderAsc == false)
            {
                query = query.OrderByDescending(orderProperty);
            }
            return await query.FirstOrDefaultAsync(criteria);
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Save changes.
        /// </summary>
        /// <returns></returns>
        private async Task<int> CommitAsync()
        {
            return await _db.SaveChangesAsync();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Get user counts.
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        public async Task<int> CountAsync(Expression<Func<User, bool>> criteria)
        {
            return await _db.Users.CountAsync(criteria);
        }
        //************************************************************************************************************************************
    }
}
