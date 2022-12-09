using Magile.Domain.Entities.Role;
using System;

namespace Magile.Domain.Entities.Users
{
    public class UserRoleEntity : BaseEntity
    {
        public UserRoleEntity(UserEntity user, RoleEntity role, Guid userId, Guid roleId)
        {
            UserId = userId;
            RoleId = roleId;
            User = user;
            Role = role;
        }

        public Guid UserId { get; private set; }
        public Guid RoleId { get; private set; }
        public UserEntity User { get; private set; }
        public RoleEntity Role { get; private set; }
    }
}