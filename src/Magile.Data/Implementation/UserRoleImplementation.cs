using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Data.Context;
using Magile.Data.Repository;
using Magile.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Magile.Data.Implementation
{
    public class UserRoleImplementation : BaseRepository<UserRoleEntity>, IUserRoleRepository
    {
        private DbSet<UserRoleEntity> _dataset;
        public UserRoleImplementation(MagileDbContext context) : base(context)
            => _dataset = context.Set<UserRoleEntity>();
    }
}