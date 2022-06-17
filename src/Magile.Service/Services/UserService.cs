using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Data.Repository;
using Magile.Domain.Entities;
using Magile.Domain.Interfaces;
using Magile.Domain.ViewModels.User;

namespace Magile.Service.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        private IBranchRepository _branchRepository;

        public UserService(IUserRepository repository, IBranchRepository branchRepository)
        {
            _repository = repository;
            _branchRepository = branchRepository;
        }

        public async Task DeleteAsync(Guid id)
            => await _repository.DeleteAsync(id);

        public async Task<IList<UserEntity>> GetAllAsync()
            => await _repository.SelectAllAsync();

        public async Task<UserEntity> GetByEmailAsync(string email)
            => await _repository.GetByEmailAsync(email);

        public async Task<UserEntity> GetByIdAsync(Guid id)
            => await _repository.SelectAsync(id);

        public async Task<UserEntity> InsertAsync(UserInsertViewModel model)
        {

            if (await _branchRepository.SelectAsync(model.BranchId) == null)
                throw new Exception("código da filial não encontrado");

            if (!(model.SupervisorId == Guid.Empty) && (await _repository.SelectAsync(model.SupervisorId) == null))
                throw new Exception("código do supervisor não encontrado");

            if (!(GetByEmailAsync(model.Email) == null))
                throw new Exception("E-mail já cadastrado");

            return await _repository.InsertAsync(UserEntity.Insert(model));
        }
        public async Task<UserEntity> InsertFinancialAsync(UserFinancialInsertViewModel model)
        {
            //ValidateInsertData(model);
            return await _repository.InsertAsync(UserEntity.InsertFinancial(model));
        }

        public async Task<UserEntity> UpdateAsync(UserUpdateViewModel model)
        {
            //ValidateInsertData(model);

            var result = await GetByIdAsync(model.Id);
            if (result == null)
                return null;

            return await _repository.UpdateAsync(UserEntity.Update(result, model));
        }

        public async Task<UserEntity> UpdateFinancialAsync(UserFinancialUpdateViewModel model)
        {
            //ValidateInsertData(model);

            var result = await GetByIdAsync(model.Id);
            if (result == null)
                return null;

            return await _repository.UpdateAsync(UserEntity.UpdateFinancial(result, model));
        }

        //private async bool ValidateData(dynamic model)
        //{
        //    if (await _branchRepository.SelectAsync(model.BranchId) == null)
        //    {
        //        return false;
        //        throw new Exception("Código da Filial não encontrado");
        //    }
                

        //    if (!(model.SupervisorId == Guid.Empty) && (await _repository.SelectAsync(model.SupervisorId) == null))
        //    {
        //        return false;
        //        throw new Exception("Código do Supervisor não encontrado");
        //    }
                

        //    if (!(GetByEmailAsync(model.Email) == null))
        //    {
        //        return false;
        //        throw new Exception("E-mail já cadastrado");
        //    }
            
        //    return true;
        //}
    }
}