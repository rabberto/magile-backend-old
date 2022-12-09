using System;

namespace Magile.Domain.Entities.Departament
{
    public sealed class DepartamentEntity : BaseEntity
    {
        public string Name { get; set; }
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
