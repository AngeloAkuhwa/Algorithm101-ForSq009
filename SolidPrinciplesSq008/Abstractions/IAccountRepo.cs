using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesSq008
{
    public interface IAccountRepo
    {
        void OpenSavingsAccount();
        void OpenCurrentAccount(Account model);
        void OpenFixedDepositAccount();
       
    }
}
