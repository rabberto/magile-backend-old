namespace Magile.Domain.Entities.Categories
{
    public sealed class CategoryFinancialEntity : CategoryEntity
    {
        public string LegalAccount { get; private set; }
        public bool? FinancialManagement { get; private set; }
    }
}
