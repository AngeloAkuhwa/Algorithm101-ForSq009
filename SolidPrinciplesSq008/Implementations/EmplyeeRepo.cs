using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesSq008
{
    public class EmplyeeRepo:IEmployeeRepo
    {
        //AccountRepo accountRepo = new AccountRepo();


        private readonly IAccountRepo _accountRepo;
        /// <summary>
        /// Constructor Injection 
        /// </summary>
        /// <param name="accountRepo"></param>
        public EmplyeeRepo(IAccountRepo accountRepo)
        {
            _accountRepo = accountRepo;
        }

        /// <summary>
        /// property Injection
        /// </summary>
        private IAccountRepo accountRepo;
        public IAccountRepo AccountRepo
        {
            get => accountRepo == null ? throw new Exception("") : accountRepo;

            set => accountRepo = value;
        }

        public void RegisterEmployee()
        {
            throw new NotImplementedException();
        }

        public void CreateEmployeeSavingsAccount(Employee model, Account account)
        {
            //property injection
            AccountRepo = new AccountRepo();

            if(model != null && account != null)
            {
                AccountRepo.OpenCurrentAccount(account);

            }

            //if(model != null && account != null)
            //{
            //    _accountRepo.OpenCurrentAccount(account);

            //}
        }
    }
}
