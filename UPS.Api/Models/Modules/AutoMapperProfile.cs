using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UPS.Api.Controllers.Dtos;
using UPS.BusinessModels.Entities;
using UPS.BusinessModels.User;
using UPS.Enums;
using UPS.Framework.Models;
using UPS.Framework.Tools;

namespace UPS.Api.Models.Modules
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto, UserModel>().ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToEnum<StatusEnum>()))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.ToEnum<GenderEnum>()));

            CreateMap<UserModel, UserDto>().ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.ToString()));

            CreateMap<RegisterUserDto, RegisterUserModel>().ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToEnum<StatusEnum>()))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.ToEnum<GenderEnum>()));

            CreateMap<UserQueryDto, UserQueryModel>();

            CreateMap<PagedResult<UserModel>, PagedResult<UserDto>>();
        }
    }
}
