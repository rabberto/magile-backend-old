using System;

namespace Magile.Domain.Entities.Company
{
    public sealed class CompanyEntity : BaseEntity
    {
        public string Name { get; private set; }
        public string SocialName { get; private set; }
        public string Document { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }

        public CompanyEntity Insert(CompanyEntity companyEntitty)
        {
            companyEntitty.Password = PasswordDefault();
            companyEntitty.Active = true;
            return companyEntitty;
        }

        public CompanyEntity Update(CompanyEntity companyEntitty)
        {
            companyEntitty.UpdateAt = DateTime.UtcNow;
            return companyEntitty;
        }
  
        private string PasswordDefault()
            => Guid.NewGuid().ToString().Replace("-", "").Substring(1, 12);
    }
}
