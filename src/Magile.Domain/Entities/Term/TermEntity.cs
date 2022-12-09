using Magile.Domain.Entities.Users;
using Magile.Domain.ViewModels.Term;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Magile.Domain.Entities.Term
{
    public class TermEntity : BaseEntity
    {
        public TermEntity()
        {
            Users = new List<UserEntity>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Base64 { get; set; }
        public bool Active { get; set; }
        public List<UserEntity> Users { get; }

        public TermEntity Insert(TermEntity termEntity)
        {
            termEntity.Active = true;
            return termEntity;
        }

        public TermEntity Update(TermEntity entity, TermUpdateViewModel model)
        {
            entity.UpdateAt = DateTime.Now;
            return entity;
        }
    }
}
