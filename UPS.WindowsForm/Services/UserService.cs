using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.WindowsForm.Models;

namespace UPS.WindowsForm.Services
{
    public class UserService
    {
        //************************************************************************************************************************************
        /// <summary>
        /// Get a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        internal static async Task<User> GetUserAsync(long userId)
        {
            var user = await HttpService.GetAsync<User>($"{ConfigurationService.GetInstance().Get("BaseUrl")}/api/public-api/users/{userId}", authorization: ConfigurationService.GetInstance().Get("Authorization"));
            return user;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Add a user.
        /// </summary>
        /// <param name="registerUser"></param>
        /// <returns></returns>
        internal static async Task<User> CreateNewUserAsync(RegisterUser registerUser)
        {
            var user = await HttpService.PostAsync<RegisterUser, User>($"{ConfigurationService.GetInstance().Get("BaseUrl")}/api/public-api/users", registerUser, authorization: ConfigurationService.GetInstance().Get("Authorization"));
            return user;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Update a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="registerUser"></param>
        /// <returns></returns>
        internal static async Task<User> UpdateUserAsync(long userId, RegisterUser registerUser)
        {
            var user = await HttpService.PutAsync<RegisterUser, User>($"{ConfigurationService.GetInstance().Get("BaseUrl")}/api/public-api/users/{userId}", registerUser, authorization: ConfigurationService.GetInstance().Get("Authorization"));
            return user;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Delete a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        internal static async Task DeleteUserAsync(long userId)
        {
            await HttpService.DeleteAsync($"{ConfigurationService.GetInstance().Get("BaseUrl")}/api/public-api/users/{userId}", authorization: ConfigurationService.GetInstance().Get("Authorization"));
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Get user list.
        /// </summary>
        /// <param name="userQuery"></param>
        /// <returns></returns>
        internal static async Task<PagedUsers> GetUsersAsync(UserQuery userQuery)
        {
            Dictionary<string, object> parameters = ParseParameters(userQuery);
           
            var user = await HttpService.GetAsync<PagedUsers>($"{ConfigurationService.GetInstance().Get("BaseUrl")}/api/public-api/users", parameters, authorization: ConfigurationService.GetInstance().Get("Authorization"));
            return user;
        }

        //************************************************************************************************************************************
        /// <summary>
        /// Get user list as csv file.
        /// </summary>
        /// <param name="userQuery"></param>
        /// <returns></returns>
        public static async Task<string> GetUsersCsvAsync(UserQuery userQuery)
        {
            Dictionary<string, object> parameters = ParseParameters(userQuery);
            var csv = await HttpService.GetAsync<string>($"{ConfigurationService.GetInstance().Get("BaseUrl")}/api/public-api/users/export-csv", parameters, authorization: ConfigurationService.GetInstance().Get("Authorization"));
            return csv;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Parse UserQuery to Dictionary<string, object>.
        /// </summary>
        /// <param name="userQuery"></param>
        /// <returns></returns>
        private static Dictionary<string, object> ParseParameters(UserQuery userQuery)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(userQuery.Email))
            {
                parameters.Add("email", userQuery.Email);
            }
            if (!string.IsNullOrEmpty(userQuery.FirstName))
            {
                parameters.Add("first_name", userQuery.FirstName);
            }
            if (!string.IsNullOrEmpty(userQuery.LastName))
            {
                parameters.Add("last_name", userQuery.LastName);
            }
            if (!string.IsNullOrEmpty(userQuery.Gender))
            {
                parameters.Add("gender", userQuery.Gender);
            }
            if (!string.IsNullOrEmpty(userQuery.Status))
            {
                parameters.Add("status", userQuery.Status);
            }
            if (userQuery.FromDate.HasValue)
            {
                parameters.Add("from_date", userQuery.FromDate.Value);
            }
            if (userQuery.ToDate.HasValue)
            {
                parameters.Add("to_date", userQuery.ToDate.Value);
            }
            if (userQuery.PageNumber.HasValue)
            {
                parameters.Add("page_number", userQuery.PageNumber.Value);
            }
            if (userQuery.PageSize.HasValue)
            {
                parameters.Add("page_size", userQuery.PageSize.Value);
            }
            return parameters;
        }
        //************************************************************************************************************************************
    }
}
