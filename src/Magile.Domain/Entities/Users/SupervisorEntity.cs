using System.Collections.Generic;

namespace Magile.Domain.Entities.Users
{
    public sealed class SupervisorEntity : UserEntity
    {
        public SupervisorEntity()
        {
            Users = new List<UserEntity>();
        }
        public List<UserEntity> Users { get; }
    }
}
