using Magile.Domain.Entities.Branch;
using System;

namespace Magile.Domain.Entities.Departament
{
    public sealed class DepartamentEntity : BaseEntity
    {
        public string Name { get; set; }
        public Guid? BranchId { get; private set; }
        public BranchEntity Branch { get; }
        public bool Active { get; set; }

        public DepartamentEntity Insert(DepartamentEntity departamentEntity)
        {
            departamentEntity.Active = true;
            return departamentEntity;
        }
        public DepartamentEntity Update(DepartamentEntity departamentEntity)
        {
            departamentEntity.UpdateAt = DateTime.Now;
            return departamentEntity;
        }
    }
}
