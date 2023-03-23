using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BasicCleanArch.Domain.Entities;

namespace BasicCleanArch.Application.Features.UserFeatures.CreateUser
{
    public sealed class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreateUserResponse>();
        }
    }
}
