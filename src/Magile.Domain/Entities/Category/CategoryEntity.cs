using Magile.Domain.Enums;
using System;

namespace Magile.Domain.Entities.Category
{
    public class CategoryEntity : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Active { get; private set; }
        public Guid ParentId { get; private set; }
        public ECategoryType Type { get; private set; }

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
