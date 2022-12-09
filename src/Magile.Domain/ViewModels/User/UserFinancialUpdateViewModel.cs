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
    public class UserFinancialUpdateViewModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; private set; }
        [Required]
        public string LastName { get; private set; }
        [Required]
        public string Email { get; private set; }
        [Required]
        public string Password { get; private set; }
        [Required]
        public string Document { get; private set; }
        [Required]
        public DateTime BirthDate { get; private set; }
        [Required]
        public string Phone { get; private set; }

        public string ExternalId { get; private set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public decimal CardLimit { get; set; }
        [Required]
        public EAccountType StatusCard { get; set; }
        [Required]
        public string CostCenter { get; set; }
        [Required]
        public string CashAccount { get; set; }
        public Guid SupervisorId { get; private set; }
        [Required]
        public Guid BranchId { get; private set; }
    }
}
