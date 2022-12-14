using Magile.Domain.Entities.Cash;
using Magile.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Magile.Domain.Entities.Categories
{
    public class CategoryEntity : BaseEntity
    {
        public CategoryEntity()
        {
            Cash = new List<CashEntity>();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Active { get; private set; }
        public Guid? ParentId { get; private set; }
        public CategoryEntity Parent { get; set; }
        public ECategoryType Type { get; private set; }
        public List<CashEntity> Cash { get; set; }

        public CategoryEntity Insert(CategoryEntity categoryEntity)
        {
            categoryEntity.Active = true;
            return categoryEntity;
        }
        public CategoryEntity Update(CategoryEntity categoryEntity)
        {
            categoryEntity.UpdateAt = DateTime.Now;
            return categoryEntity;
        }
    }
}
