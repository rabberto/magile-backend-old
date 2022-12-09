using Magile.Domain.Enums;
using System;

namespace Magile.Domain.Entities.Users
{
    public class UserFinancialEntity : UserEntity
    {
        public string CardNumber { get; set; }
        public decimal CardLimit { get; set; }
        public EAccountType StatusCard { get; set; }
        public string CostCenter { get; set; }
        public string CashAccount { get; set; }

        public static UserFinancialEntity Insert(UserFinancialEntity userFinancialEntity)
            => userFinancialEntity;

        public static UserFinancialEntity Update(UserFinancialEntity userFinancialEntity)
        {
            userFinancialEntity.UpdateAt = DateTime.UtcNow;
            return userFinancialEntity;
        }
    }
}
