using Magile.Domain.Entities.Term;
using System;

namespace Magile.Domain.Entities.Users
{
    public class UserTermEntity : BaseEntity
    {
        public UserTermEntity(UserEntity user, TermEntity term, Guid userId, Guid termId)
        {
            UserId = userId;
            TermId = termId;
            User = user;
            Term = term;
        }
        public Guid UserId { get; private set; }
        public Guid TermId { get; private set; }
        public UserEntity User { get; set; }
        public TermEntity Term { get; private set; }
    }
}