using Magile.Domain.ViewModels.Term;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Magile.Domain.Entities
{
    public class TermEntity : BaseEntity
    {
        public TermEntity()
        {

        } 
        public TermEntity(string name, string description, string base64)
        {
            Name = name;
            Description = description;
            Base64 = base64;
            IsActive = true;
            Users = new List<UserEntity>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Base64 { get; set; }
        public bool IsActive { get; set; }
        public List<UserEntity> Users { get; }


        public TermEntity Insert(TermInsertViewModel model)
        {
            var entity = new TermEntity();
            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.Base64 = model.Base64;
            entity.IsActive = true;
            entity.CreateAt = DateTime.Now;
            entity.UserCreateAt = model.UserCreateAt;
            return entity;
        }

        public TermEntity Update(TermEntity entity, TermUpdateViewModel model)
        {
            
            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.Base64 = model.Base64;
            entity.IsActive = model.IsActive;
            entity.UpdateAt = DateTime.Now;
            entity.UserUpdateAt = model.UserUpdateAt;
            return entity;
        }
    }
}
