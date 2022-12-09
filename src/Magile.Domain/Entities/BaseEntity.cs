using System;

namespace Magile.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; }
        private DateTime? _createAt { get; set; }
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }
        public DateTime UpdateAt { get; set; }
        public string UserCreateAt { get; private set; }
        public string UserUpdateAt { get; private set; }
    }
}