using Magile.Domain.Entities.Category;

namespace Magile.Domain.Entities.CategoryFinancial
{
    public sealed class CategoryFinancialEntity : CategoryEntity
    {
        public string LegalAccount { get; private set; }
        public bool? FinancialManagement { get; private set; }
    }
}
