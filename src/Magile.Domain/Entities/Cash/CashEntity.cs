using Magile.Domain.Entities.Users;
using Magile.Domain.Enums;
using System;

namespace Magile.Domain.Entities.Cash
{
    public sealed class CashEntity : BaseEntity
    {
        public Guid UserId { get; private set; }
        public UserEntity User { get; private set; }
        public EOperationCash Operation { get; private set; }
    }
}
