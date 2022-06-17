using System;
using System.Collections.Generic;
using Magile.Domain.Enums;
using Magile.Domain.Interfaces;
using Magile.Domain.ViewModels.User;

namespace Magile.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public UserEntity()
        {

        }

        public UserEntity(string firstName, string lastName, string email, string password, string document, DateTime birthDate, string phone, string externalId, string cardNumber, decimal cardLimit, EFinancialType statusCard, string costCenter, string cashAccount, Guid supervisorId, Guid branchId)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Document = document;
            KeyValidation = Guid.NewGuid(); ;
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

        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Email { get;  set; }
        public string Password { get;  set; }
        public string Document { get;  set; }
        public Guid KeyValidation { get;  set; }
        public DateTime BirthDate { get;  set; }
        public bool IsActive { get;  set; }
        public string Phone { get;  set; }
        public string ExternalId { get;  set; }
        public string CardNumber { get; set; }
        public decimal CardLimit { get; set; }
        public EFinancialType StatusCard { get; set; }
        public string CostCenter { get; set; }
        public string CashAccount { get; set; }
        public Guid? SupervisorId { get;  set; }
        public UserEntity Supervisor { get;  set; }
        public Guid BranchId { get; set; }
        public BranchEntity Branch { get;  set; }
        public List<TermEntity> Terms { get; }
        public List<RoleEntity> Roles { get; }

        public static UserEntity Insert(UserInsertViewModel model)
        {
            var userEntity = new UserEntity();
            userEntity.FirstName = model.FirstName;
            userEntity.LastName = model.LastName;
            userEntity.Email = model.Email;
            userEntity.Document = model.Document;
            userEntity.BirthDate = model.BirthDate;
            userEntity.Phone = model.Phone;
            userEntity.ExternalId = model.ExternalId;
            userEntity.StatusCard = EFinancialType.NoCard;
            userEntity.SupervisorId = (model.SupervisorId == Guid.Empty ? null : model.SupervisorId);
            userEntity.BranchId = model.BranchId;
            userEntity.Password = PasswordDefault();
            return userEntity;
        }

        public static UserEntity InsertFinancial(UserFinancialInsertViewModel model)
        {
            var userEntity = new UserEntity();
            userEntity.FirstName = model.FirstName;
            userEntity.LastName = model.LastName;
            userEntity.Email = model.Email;
            userEntity.Document = model.Document;
            userEntity.BirthDate = model.BirthDate;
            userEntity.Phone = model.Phone;
            userEntity.ExternalId = model.ExternalId;
            userEntity.StatusCard = model.StatusCard;
            userEntity.SupervisorId = model.SupervisorId;
            userEntity.BranchId = model.BranchId;
            userEntity.CardNumber = model.CardNumber;
            userEntity.CardLimit = model.CardLimit;
            userEntity.StatusCard = model.StatusCard;
            userEntity.CostCenter = model.CostCenter;
            userEntity.CashAccount = model.CashAccount;
            userEntity.Password = PasswordDefault();
            return userEntity;
        }

        public static UserEntity Update(UserEntity entity, UserUpdateViewModel model)
        {
            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.Email = model.Email;
            entity.Document = model.Document;
            entity.BirthDate = model.BirthDate;
            entity.Phone = model.Phone;
            entity.ExternalId = model.ExternalId;
            entity.StatusCard = EFinancialType.NoCard;
            entity.SupervisorId = model.SupervisorId;
            entity.BranchId = model.BranchId;
            entity.Password = PasswordDefault();
            return entity;
        }

        public static UserEntity UpdateFinancial(UserEntity entity, UserFinancialUpdateViewModel model)
        {
            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.Email = model.Email;
            entity.Document = model.Document;
            entity.BirthDate = model.BirthDate;
            entity.Phone = model.Phone;
            entity.ExternalId = model.ExternalId;
            entity.StatusCard = model.StatusCard;
            entity.SupervisorId = model.SupervisorId;
            entity.BranchId = model.BranchId;
            entity.CardNumber = model.CardNumber;
            entity.CardLimit = model.CardLimit;
            entity.StatusCard = model.StatusCard;
            entity.CostCenter = model.CostCenter;
            entity.CashAccount = model.CashAccount;
            entity.Password = PasswordDefault();
            return entity;
        }

        public static string PasswordDefault()
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(1, 8);
        }

        public bool ChangePassword(UserEntity user, string password, string newPassword)
        {
            if(password == newPassword)
                return false; //criar exception

            if(password == null || newPassword == null)
                return false; //criar exception

            if(password.Length <= 8)
                return false; //criar exception

            user.Password = newPassword;
            return true;
        }
    }
 }