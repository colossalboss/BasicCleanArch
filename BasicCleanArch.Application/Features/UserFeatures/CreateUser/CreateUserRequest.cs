using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace BasicCleanArch.Application.Features.UserFeatures.CreateUser
{
    public sealed class CreateUserRequest : IRequest<CreateUserResponse>
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
