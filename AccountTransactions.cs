using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem02
{
    internal class AccountTransactions
    {
        public int AccountNumber { get; set; }
        public int NicNumber { get; set; }
        public string UserName { get; set; }
        public float DepositAmount { get; set; }

        public AccountTransactions(int accountNumber, int nicNumber, string userName, float depositAmount)
        {
            AccountNumber = accountNumber;
            NicNumber = nicNumber;
            UserName = userName;
            DepositAmount = depositAmount;
        }


    }
}
