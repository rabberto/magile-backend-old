using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public class RoleEntity : BaseEntity
    {
        public RoleEntity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<UserEntity> Users { get; }
    }
}