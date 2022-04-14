using System;

namespace Magile.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        private DateTime? _createAt { get; set; }
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }
        public DateTime UpdateAt { get; set; }
        public string UserCreateAt { get; set; }
        public string UserUpdateAt { get; set; }
    }
}