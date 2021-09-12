using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UPS.Abstract.Repositories;
using UPS.Abstract.Services;
using UPS.BusinessModels.Entities;
using UPS.BusinessModels.User;
using UPS.Framework.DI;
using UPS.Framework.Exceptions;
using UPS.Framework.Models;
using UPS.Framework.Tools;

namespace UPS.BusinessServices.Services
{
    public class UserService : IUserService, ITransientLifetime
    {
        //************************************************************************************************************************************
        //Variables:
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        //************************************************************************************************************************************
        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Add a user.
        /// </summary>
        /// <param name="registerUser"></param>
        /// <returns></returns>
        public async Task<UserModel> AddAsync(RegisterUserModel registerUser)
        {
            if (!registerUser.Email.IsValidEmail())
                throw new UPSExceptionInvalidParameter($"Invalid Email Format: {registerUser.Email}", errorCode: "INVALID_EMAIL");
            User user = await _userRepository.FirstOrDefaultAsync(x => x.Email == registerUser.Email);
            if (user != null)
                throw new UPSBusinessException($"Duplicate User Email: {registerUser.Email}", errorCode: "DUPLICATE_EMAIL");
            User newUser = _mapper.Map<User>(registerUser);
            var addedUser = await _userRepository.AddAsync(newUser);
            UserModel userModel = _mapper.Map<UserModel>(addedUser);
            return userModel;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Remove a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task DeleteAsync(long userId)
        {
            User user = await _userRepository.GetAsync(userId);
            if (user == null)
                throw new UPSExceptionNotFound($"User Not Found.", errorCode: "USER_NOT_FOUND");
            await _userRepository.DeleteAsync(userId);
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Get a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<UserModel> GetAsync(long userId)
        {
            User user = await _userRepository.GetAsync(userId);
            if (user == null)
                throw new UPSExceptionNotFound($"User Not Found.", errorCode: "USER_NOT_FOUND");
            UserModel userModel = _mapper.Map<UserModel>(user);
            return userModel;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Get users.
        /// </summary>
        /// <param name="userQuery"></param>
        /// <returns></returns>
        public async Task<PagedResult<UserModel>> GetAsync(UserQueryModel userQuery)
        {
            PagedResult<UserModel> pagedResult = new PagedResult<UserModel>();

            int pageNumber = 1;
            if (userQuery.PageNumber.HasValue && userQuery.PageNumber > 0)
                pageNumber = userQuery.PageNumber.Value;

            int pageSize = 20;
            if (userQuery.PageSize.HasValue && userQuery.PageSize > 0)
            {
                pageSize = userQuery.PageSize.Value;
            }

            int skipItems = (pageNumber - 1) * pageSize;

            //create query
            Expression<Func<User, bool>> criteria = (x =>
            (string.IsNullOrEmpty(userQuery.FirstName) ? true : x.FirstName.Contains(userQuery.FirstName)) &&
            (string.IsNullOrEmpty(userQuery.LastName) ? true : x.LastName.Contains(userQuery.LastName)) &&
            (string.IsNullOrEmpty(userQuery.Email) ? true : x.Email.Equals(userQuery.Email)) &&
            (userQuery.FromDate == null ? true : x.CreationTime >= userQuery.FromDate.Value.Date) &&
            (userQuery.ToDate == null ? true : x.CreationTime <= userQuery.ToDate.Value.Date.AddDays(+1)) &&
            (userQuery.Gender == null ? true : x.Gender == userQuery.Gender) &&
            (userQuery.Status == null ? true : x.Status == userQuery.Status));

            int totalCount = await _userRepository.CountAsync(criteria);

            //A higher and invalid pageNumber is requested.
            if (skipItems + pageSize > totalCount)
            {
                if ((totalCount % pageSize) > 0)
                {
                    pageNumber = (totalCount / pageSize);
                    skipItems = pageNumber * pageSize;
                }
                else
                {
                    pageNumber = ((totalCount / pageSize) - 1);
                    skipItems = pageNumber * pageSize;
                }
                if (pageNumber == 0)
                    pageNumber++;
            }

            List<User> users = await _userRepository.WhereAsync(criteria, o => o.CreationTime, skip: skipItems, take: pageSize);

            pagedResult.PageNumber = pageNumber;
            pagedResult.PageSize = pageSize;
            pagedResult.TotalCount = totalCount;
            pagedResult.Items = _mapper.Map<List<UserModel>>(users);
            return pagedResult;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Update user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="registerUser"></param>
        /// <returns></returns>
        public async Task<UserModel> UpdateAsync(long userId, RegisterUserModel registerUser)
        {
            if (!registerUser.Email.IsValidEmail())
                throw new UPSExceptionInvalidParameter($"Invalid Email Format: {registerUser.Email}", errorCode: "INVALID_EMAIL");
            User user = await _userRepository.GetAsync(userId);
            if (user == null)
                throw new UPSExceptionNotFound($"User Not Found.", errorCode: "USER_NOT_FOUND");
            User userEmail = await _userRepository.FirstOrDefaultAsync(x => x.Email == registerUser.Email);
            if (userEmail != null && userId != userEmail.Id)
                throw new UPSBusinessException($"Duplicate User Email: {user.Email}", errorCode: "DUPLICATE_EMAIL");
            var mappedUser = _mapper.Map(registerUser, user);
            User updatedUser = await _userRepository.UpdateAsync(mappedUser);
            UserModel userModel = _mapper.Map<UserModel>(updatedUser);
            return userModel;
        }
        //************************************************************************************************************************************
    }
}
