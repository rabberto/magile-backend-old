using Magile.Domain.Entities.Users;
using System;

namespace Magile.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreateAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime? UpdateAt { get; set; }
        public Guid UserCreateId { get; set; }
        public UserEntity UserCreate { get; }
        public Guid? UserUpdateId { get; set; }
        public UserEntity UserUpdate { get; }

        public void Insert(Guid userCreateId)
            => UserCreateId = userCreateId;
    }
}