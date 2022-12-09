using Magile.Domain.Entities.Users;
using System;
using System.Collections.Generic;

namespace Magile.Domain.Entities.Branch
{
    public class BranchEntity : BaseEntity
    {
        public BranchEntity()
        {
            Users = new List<UserEntity>();
        }

        public string Name { get; private set; }
        public bool Active { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public bool Matrix { get; private set; }
        public string ExternalId { get; private set; }
        public List<UserEntity> Users { get; }

        public BranchEntity Insert(BranchEntity branchEntity)
        {
            branchEntity.Active = true;
            return branchEntity;
        }
        public BranchEntity Update(BranchEntity branchEntity)
        {
            branchEntity.UpdateAt = DateTime.Now;
            return branchEntity;
        }
    }
}