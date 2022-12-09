using Magile.Domain.Entities.Branch;
using Magile.Domain.Entities.Role;
using Magile.Domain.Entities.Term;
using System;
using System.Collections.Generic;

namespace Magile.Domain.Entities.Users
{
    public class UserEntity : BaseEntity
    {
        public UserEntity()
        {
            Terms = new List<TermEntity>();
            Roles = new List<RoleEntity>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Document { get; private set; }
        public Guid KeyValidation { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Active { get; private set; }
        public string Phone { get; private set; }
        public string? ExternalId { get; private set; }
        public Guid? SupervisorId { get; private set; }
        public Guid? BranchId { get; private set; }
        public UserEntity Supervisor { get; }
        public BranchEntity Branch { get; }
        public List<TermEntity> Terms { get; }
        public List<RoleEntity> Roles { get; }

        public UserEntity Insert(UserEntity entity)
        {
            entity.Active = false;
            entity.Password = PasswordDefault();
            entity.KeyValidation = Guid.NewGuid();            
            return entity;
        }

        public UserEntity Update(UserEntity entity)
        {
            entity.UpdateAt = DateTime.UtcNow;
            return entity;
        }

        private string PasswordDefault()
            => Guid.NewGuid().ToString().Replace("-", "").Substring(1, 8);

        public bool ChangePassword(UserEntity user, string password, string newPassword)
        {
            if (password == newPassword)
                return false; //criar exception

            if (password == null || newPassword == null)
                return false; //criar exception

            if (password.Length <= 8)
                return false; //criar exception

            user.Password = newPassword;
            return true;
        }
    }
}