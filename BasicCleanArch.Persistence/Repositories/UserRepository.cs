using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BasicCleanArch.Application.Repositories;
using BasicCleanArch.Domain.Entities;
using BasicCleanArch.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BasicCleanArch.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {

        }
        public Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}
