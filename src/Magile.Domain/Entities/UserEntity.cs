using System;
using System.Collections.Generic;
using System.Linq;
using Magile.Domain.Enums;

namespace Magile.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public UserEntity(string firstName, string lastName, string email, string document, DateTime birthDate, string phone, string externalId, string cardNumber, decimal cardLimit, EFinancialType statusCard, string costCenter, string cashAccount, Guid supervisorId, Guid branchId)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = "password";
            Document = document;
            Key = Guid.NewGuid(); ;
            BirthDate = birthDate;
            IsActive = true;
            Phone = phone;
            ExternalId = externalId;
            CardNumber = cardNumber;
            CardLimit = cardLimit;
            StatusCard = statusCard;
            CostCenter = costCenter;
            CashAccount = cashAccount;
            SupervisorId = supervisorId;
            BranchId = branchId;
            Terms = new List<TermEntity>();
            Roles = new List<RoleEntity>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Document { get; private set; }
        public Guid Key { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool IsActive { get; private set; }
        public string Phone { get; private set; }
        public string ExternalId { get; private set; }
        public string CardNumber { get; set; }
        public decimal CardLimit { get; set; }
        public EFinancialType StatusCard { get; set; }
        public string CostCenter { get; set; }
        public string CashAccount { get; set; }
        public Guid SupervisorId { get; private set; }
        public UserEntity Supervisor { get; private set; }
        public Guid BranchId { get; private set; }
        public BranchEntity Branch { get; private set; }
        public List<TermEntity> Terms { get; }
        public List<RoleEntity> Roles { get; }
    }
}