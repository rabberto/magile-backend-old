using Magile.Domain.Entities;
using Magile.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magile.Domain.ViewModels.User
{
    public class UserFinancialInsertViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Document { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Phone { get; set; }

        public string ExternalId { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public decimal CardLimit { get; set; }
        [Required]
        public EFinancialType StatusCard { get; set; }
        [Required]
        public string CostCenter { get; set; }
        [Required]
        public string CashAccount { get; set; }
        public Guid SupervisorId { get; set; }
        [Required]
        public Guid BranchId { get; set; }
    }
}
