using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UPS.Abstract.Services;
using UPS.Api.Controllers.Dtos;
using UPS.BusinessModels.User;
using UPS.Framework.AspNet.Mvc;
using UPS.Framework.Models;

namespace UPS.Api.Controllers
{
    /// <summary>
    /// Simple crud.
    /// </summary>
    [Route("api/public-api/users")]
    [ApiController]
    [UPSAuthorize]
    public class UserController : UPSControllerBase
    {
        //************************************************************************************************************************************
        //Variables:
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        //************************************************************************************************************************************
        public UserController(ILogger<UserController> logger, IUserService userService, IMapper mapper) : base(logger)
        {
            _userService = userService;
            _mapper = mapper;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Add new user.
        /// </summary>
        /// <param name="registerUserDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<UserDto> CreateNewUser([FromBody] RegisterUserDto registerUserDto)
        {
            RegisterUserModel registerUserModel = _mapper.Map<RegisterUserModel>(registerUserDto);
            var userModel = await _userService.AddAsync(registerUserModel);
            UserDto userDto = _mapper.Map<UserDto>(userModel);
            return userDto;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Update User.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="registerUserDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<UserDto> UpdateUser([FromRoute] long id, [FromBody] RegisterUserDto registerUserDto)
        {
            RegisterUserModel registerUserModel = _mapper.Map<RegisterUserModel>(registerUserDto);
            var userModel = await _userService.UpdateAsync(id, registerUserModel);
            UserDto userDto = _mapper.Map<UserDto>(userModel);
            return userDto;
        }

        //************************************************************************************************************************************
        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public async Task DeleteUser([FromRoute] long id)
        {
            await _userService.DeleteAsync(id);
        }

        //************************************************************************************************************************************
        /// <summary>
        /// Get user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<UserDto> GetUser([FromRoute] long id)
        {
            var userModel = await _userService.GetAsync(id);
            UserDto userDto = _mapper.Map<UserDto>(userModel);
            return userDto;
        }

        //************************************************************************************************************************************
        /// <summary>
        /// Get user list.
        /// </summary>
        /// <param name="userQueryDto"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResult<UserDto>> GetUserList( [FromQuery]UserQueryDto userQueryDto)
        {
            UserQueryModel userQueryModel = _mapper.Map<UserQueryModel>(userQueryDto);
            var usersPagedResult = await _userService.GetAsync(userQueryModel);
            return _mapper.Map<PagedResult<UserDto>>(usersPagedResult);
        }

        //************************************************************************************************************************************
        /// <summary>
        /// Get user list as a csv file.
        /// </summary>
        /// <param name="userQueryDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("export-csv")]
        public async Task<FileResult> RetrieveFile([FromQuery] UserQueryDto userQueryDto)
        {
            UserQueryModel userQueryModel = _mapper.Map<UserQueryModel>(userQueryDto);
            var usersPagedResult = await _userService.GetAsync(userQueryModel);
            return File(Encoding.ASCII.GetBytes(WriteTsv(usersPagedResult.Items)), $"application/vnd.ms-excel", $"User-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.csv");
        }

        //************************************************************************************************************************************
        /// <summary>
        /// To convert Generic data to CSV (',' Separated Values) Format
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        private string WriteTsv<T>(IEnumerable<T> data)
        {
            StringBuilder output = new StringBuilder();
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor prop in props)
            {
                output.Append(prop.DisplayName); // header
                output.Append(",");
            }
            output.AppendLine();
            foreach (T item in data)
            {
                foreach (PropertyDescriptor prop in props)
                {
                    output.Append(prop.Converter.ConvertToString(
                         prop.GetValue(item)));
                    output.Append(",");
                }
                output.AppendLine();
            }
            return output.ToString();
        }
        //************************************************************************************************************************************


    }
}
