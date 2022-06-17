using Magile.Domain.ViewModels.Role;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Magile.Domain.Entities
{
    public class RoleEntity : BaseEntity
    {

        public RoleEntity()
        {
        }
        public RoleEntity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<UserEntity> Users { get; }
        
        public RoleEntity Insert(RoleInsertViewModel model)
        {
            var entity = new RoleEntity();
            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.UserCreateAt = model.UserCreateAt;
            entity.CreateAt = DateTime.Now;
            return entity;
        }

        public RoleEntity Update(RoleEntity entity, RoleUpdateViewModel model)
        {
            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.UserUpdateAt = model.UserUpdateAt;
            entity.UpdateAt = DateTime.Now;
            return entity;        
        }
    }
}