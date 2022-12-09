using Magile.Domain.Entities.Users;
using Magile.Domain.ViewModels.Role;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Magile.Domain.Entities.Role
{
    public class RoleEntity : BaseEntity
    {

        public RoleEntity()
        {
            Users = new List<UserEntity>();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Acitve { get; private set; }
        public List<UserEntity> Users { get; }

        public RoleEntity Insert(RoleEntity roleEntity)
        {
            roleEntity.Acitve = true;
            roleEntity.CreateAt = DateTime.Now;
            return roleEntity;
        }

        public RoleEntity Update(RoleEntity roleEntity)
        {
            roleEntity.UpdateAt = DateTime.Now;
            return roleEntity;
        }
    }
}