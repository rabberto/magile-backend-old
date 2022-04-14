using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public class TermEntity : BaseEntity
    {
        public TermEntity(string name, string description, string base64)
        {
            Name = name;
            Description = description;
            Base64 = base64;
            IsActive = true;
            Users = new List<UserEntity>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Base64 { get; set; }
        public bool IsActive { get; set; }
        public List<UserEntity> Users { get; }
    }
}
