using Magile.Domain.Entities.Role;
using System;

namespace Magile.Domain.Entities.Users
{
    public class UserRoleEntity : BaseEntity
    {
        public UserRoleEntity(Guid userId, Guid roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }

        public Guid UserId { get; private set; }
        public Guid RoleId { get; private set; }
        public UserEntity User { get; }
        public RoleEntity Role { get; }

        public UserRoleEntity Insert(UserRoleEntity userRoleEntity)
            => userRoleEntity;
    }
}