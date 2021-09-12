using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.BusinessModels.Entities;
using UPS.BusinessModels.User;

namespace UPS.BusinessServices.Mudole
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterUserModel, User>();
            CreateMap<User, UserModel>();
        }
    }
}
