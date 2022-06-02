using System;
using System.Collections.Generic;
using System.Linq;
using Magile.Domain.Models;

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

        public void ChangeStatus(bool isActive, string userUpdateAt)
        {
            IsActive = isActive;
            UpdateAt = DateTime.Now;
            UserUpdateAt = userUpdateAt;
        }

        public BranchEntity UpdateEntity(BranchEntity entity, BranchUpdateModel mode)
        {
            entity.Name = mode.Name;
            entity.Address = mode.Address;
            entity.Phone = mode.Phone;
            entity.ExternalId = mode.ExternalId;
            entity.Matrix = mode.Matrix;
            entity.UpdateAt = DateTime.Now;
            entity.UserUpdateAt = mode.UserUpdateAt;
            return entity;
        }
    }
}