using System;
using System.Collections.Generic;
using System.Linq;
using Magile.Domain.ViewModels.Branch;

namespace Magile.Domain.Entities
{
    public class BranchEntity : BaseEntity
    {
        private IList<UserEntity> _users;

        public BranchEntity()
        {
            _users = new List<UserEntity>();
        }

        public BranchEntity(string name, string address, string phone, string externalId)
        {
            Name = name;
            IsActive = true;
            Address = address;
            Phone = phone;
            ExternalId = externalId;
            _users = new List<UserEntity>();
        }

        public string Name { get; private set; }
        public bool IsActive { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public bool Matrix { get; private set; }
        public string ExternalId { get; private set; }
        public IReadOnlyCollection<UserEntity> Users { get { return _users.ToArray(); } }

        public BranchEntity Insert(BranchInsertViewModel model)
        {
            var entity = new BranchEntity();
            entity.Name = model.Name;
            entity.Address = model.Address;
            entity.Phone = model.Phone;
            entity.ExternalId = model.ExternalId;
            entity.Matrix = model.Matrix;
            entity.UpdateAt = DateTime.Now;
            entity.UserCreateAt = model.UserCreateAt;
            entity.IsActive = true;
            return entity;
        }
        public BranchEntity Update(BranchEntity entity, BranchUpdateViewModel model)
        {
            entity.Name = model.Name;
            entity.Address = model.Address;
            entity.Phone = model.Phone;
            entity.ExternalId = model.ExternalId;
            entity.Matrix = model.Matrix;
            entity.UpdateAt = DateTime.Now;
            entity.UserUpdateAt = model.UserUpdateAt;
            entity.IsActive = model.IsActive;
            return entity;
        }
    }
}