using AutoMapper;
using Moq;
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
using UPS.BusinessServices.Services;
using UPS.Framework.Exceptions;
using Xunit;

namespace UPS.Tests.UserServiceTest
{
    public class UserServiceTests
    {
        //************************************************************************************************************************************
        //Variables:
        private readonly Mock<IUserRepository> _userRepositoryMock;
        private readonly Mock<IMapper> _mapper;
        private readonly RegisterUserModel _registerUserModel;
        private readonly UserModel _userModel;
        private readonly User _newUser;
        //************************************************************************************************************************************
        public UserServiceTests()
        {
            _userRepositoryMock = new Mock<IUserRepository>();
            _mapper = new Mock<IMapper>();

            _registerUserModel = new RegisterUserModel
            {
                FirstName = "M",
                LastName = "M",
                Email = "Mirzaie.nigje@gmail.com",
                Gender = Enums.GenderEnum.Male,
                Status = Enums.StatusEnum.Active
            };
            _userModel = new UserModel
            {
                Id = 1,
                FirstName = "M",
                LastName = "M",
                Email = "Mirzaie.nigje@gmail.com",
                Gender = Enums.GenderEnum.Male,
                Status = Enums.StatusEnum.Active
            };

            _newUser = new User()
            {
                Id = 1,
                FirstName = "M",
                LastName = "M",
                Email = "Mirzaie.nigje@gmail.com",
                Gender = Enums.GenderEnum.Male,
                Status = Enums.StatusEnum.Active
            };
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Test UserService.AddAsyc().
        /// </summary>
        [Fact]
        public async void Task_Add_New_User_Successfully()
        {
            User nullUser = null;

            _mapper.Setup(x => x.Map<User>(_registerUserModel)).Returns(_newUser);
            _mapper.Setup(x => x.Map<UserModel>(_newUser)).Returns(_userModel);

            _userRepositoryMock.Setup(p => p.AddAsync(_newUser)).ReturnsAsync(_newUser);
            _userRepositoryMock.Setup(p => p.FirstOrDefaultAsync(x => x.Email == _registerUserModel.Email, null, true)).ReturnsAsync(nullUser);

            IUserService userService = new UserService(_mapper.Object, _userRepositoryMock.Object);
            var result = await userService.AddAsync(_registerUserModel);
            Assert.True(result.Id > 0 && result.Email == _registerUserModel.Email);
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Test UserService.UpdateAsync() .
        /// </summary>
        [Fact]
        public async void Task_Update_User_Successfully()
        {
            User oldUser = new User
            {
                Id = 1,
                FirstName = "M",
                LastName = "M",
                Email = "Test@Test.com",
                Gender = Enums.GenderEnum.Male,
                Status = Enums.StatusEnum.InActive
            };
            User mapppedUser = new User
            {
                Id = 1,
                FirstName = "M",
                LastName = "M",
                Email = "Mirzaie.nigje@gmail.com",
                Gender = Enums.GenderEnum.Male,
                Status = Enums.StatusEnum.Active
            };
            long userId = 1;
            User nullUser = null;

            _mapper.Setup(x => x.Map(_registerUserModel, oldUser)).Returns(mapppedUser);
            _mapper.Setup(x => x.Map<UserModel>(_newUser)).Returns(_userModel);

            _userRepositoryMock.Setup(p => p.GetAsync(1)).ReturnsAsync(oldUser);
            _userRepositoryMock.Setup(p => p.UpdateAsync(mapppedUser)).ReturnsAsync(_newUser);
            _userRepositoryMock.Setup(p => p.FirstOrDefaultAsync(x => x.Email == _newUser.Email, null, true)).ReturnsAsync(nullUser);

            IUserService userService = new UserService(_mapper.Object, _userRepositoryMock.Object);
            var result = await userService.UpdateAsync(userId, _registerUserModel);
            Assert.False(result.Email == oldUser.Email);
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Test UserService.GetUserAsync().
        /// </summary>
        [Fact]
        public async void Task_Get_User_UnSuccessfully()
        {
            long userId = 2;
            User nullUser = null;
            _mapper.Setup(x => x.Map<UserModel>(_newUser)).Returns(_userModel);
            _userRepositoryMock.Setup(p => p.GetAsync(2)).ReturnsAsync(nullUser);
            IUserService userService = new UserService(_mapper.Object, _userRepositoryMock.Object);
            Func<Task> act = () => userService.GetAsync(userId);
            Exception exp = await Assert.ThrowsAsync<UPSExceptionNotFound>(act);
            Assert.True( exp != null);
        }
        //************************************************************************************************************************************
    }
}
