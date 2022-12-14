﻿using Magile.Domain.Entities.Branch;
using Magile.Domain.Entities.Categories;
using Magile.Domain.Entities.Users;
using Magile.Domain.Enums;
using System;

namespace Magile.Domain.Entities.Cash
{
    public sealed class CashEntity : BaseEntity
    {
        private readonly DateTime _initialDate = DateTime.MinValue;

        public UserEntity User { get; set; }
        public Guid BranchId { get; private set; }
        public BranchEntity Branch { get; private set; }
        public DateTime IssueDate { get; private set; }
        public string DocumentNumber { get; private set; }
        public decimal Value { get; private set; }
        public bool Card { get; private set; }
        public EOperationCash Operation { get; private set; }
        public Guid CategoryParentId { get; }
        public CategoryFinancialEntity CategoryParent { get; }
        public Guid CategoryId { get; private set; }
        public CategoryFinancialEntity Category { get; }
        public string EvidenceCloudPath { get; private set; }
        public string EvidenceName { get; private set; }
        public EStatusCash Status { get; private set; }
        public string History { get; private set; }

        public CashEntity Insert(CashEntity cashEntity)
        {
            if (cashEntity.IssueDate == _initialDate)
                cashEntity.IssueDate = DateTime.UtcNow;

            cashEntity.Status = EStatusCash.Pending;

            return cashEntity;
        }

        public CashEntity Update(CashEntity cashEntity)
        {
            cashEntity.UpdateAt = DateTime.UtcNow;
            return cashEntity;
        }

        public void AproovedLaunch()
            => Status = EStatusCash.Approved;

        public void RefusedLaunhc()
            => Status = EStatusCash.Refused;

        public void DefinitelyRefusedLaunch()
            => Status = EStatusCash.DefinitelyRefused;
    }
}
