using Magile.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magile.Domain.Entities
{
    public  class UserFinancialEntity
    {
        public string CardNumber { get; set; }
        public decimal CardLimit { get; set; }
        public EFinancialType StatusCard { get; set; }
        public string CostCenter { get; set; }
        public string CashAccount { get; set; }
    }
}
